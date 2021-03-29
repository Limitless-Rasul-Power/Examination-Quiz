using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_First_Quiz.Entity_Classes;
using WindowsForms_First_Quiz.File_Helper_Classes;
using WindowsForms_First_Quiz.Static_Classes;


namespace WindowsForms_First_Quiz.Take_an_Examination_Choice
{
    public partial class ExaminationControl : UserControl
    {
        private readonly List<QuestionBlock> _questions = new List<QuestionBlock>();
        private readonly List<ExamQuestionsControl> _examQuestions = new List<ExamQuestionsControl>();
        private readonly Timer _timer = new Timer();
        private TimeSpan _timeSpan = new TimeSpan();
        private int _currentNumberOfQuestion = 0;


        private readonly SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine();
        private readonly SpeechSynthesizer Lucy = new SpeechSynthesizer();
        private readonly SpeechRecognitionEngine _startListening = new SpeechRecognitionEngine();
        private readonly List<string> _grammers = new List<string>();

        public ExaminationControl()
        {
            InitializeComponent();
        }

        public ExaminationControl(List<QuestionBlock> questions)
        {
            InitializeComponent();

            if (questions != null)
            {
                _questions = questions;

                for (int i = 0; i < _questions.Count; i++)
                {
                    _examQuestions.Add(new ExamQuestionsControl());

                    _examQuestions[i].QuestionNumber = i + 1;
                    _examQuestions[i].Question = _questions[i].Text;

                    _examQuestions[i].FirstAnswer = _questions[i].Answers[QuestionChoices.FirstAnswer]; ;
                    _examQuestions[i].SecondAnswer = _questions[i].Answers[QuestionChoices.SecondAnswer];
                    _examQuestions[i].ThirdAnswer = _questions[i].Answers[QuestionChoices.ThirdAnswer];
                    _examQuestions[i].FourthAnswer = _questions[i].Answers[QuestionChoices.FourthAnswer];

                    Controls.Add(_examQuestions[i]);

                }

                #region Speech

                Lucy.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Teen);

                JsonFileHelper.JSONDeSerialization(ref _grammers, "Commands/During test time");

                _recognizer.SetInputToDefaultAudioDevice();

                GrammarBuilder gb = new GrammarBuilder();                
                gb.Append(new Choices(_grammers.ToArray()), 1, 11);

                _recognizer.LoadGrammarAsync(new Grammar(gb));

                _recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Default_SpeechRecognized);
                _recognizer.RecognizeAsync(RecognizeMode.Multiple);

                _startListening.SetInputToDefaultAudioDevice();
                _startListening.LoadGrammarAsync(new Grammar(gb));
                _startListening.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(StartListening_SpeechRecognized);
                _startListening.RecognizeAsyncCancel();

                Lucy.Rate = -2;

                _grammers.Clear();

                #endregion

                _timeSpan += TimeSpan.FromMinutes(1.5 * _questions.Count);
                TimerLbl.Text = _timeSpan.ToString("c");

                _timer.Start();
                _timer.Interval = 1000;
                _timer.Tick += Timer_Tick;

            }

            if (_questions.Count == 1)
                Next.Visible = false;

            QuestionCounterLbl.Text = $"Question {_currentNumberOfQuestion + 1} of {_questions.Count}";

            Lucy.SpeakAsync("Hello, I am Lucy, I'm here to make the exam easier, helping words: option 1, option 2, option 3, last option, read question, say read option then say number in the fourth option say read last option, next, previous, submit, back to exams, If you don't need my help just say, don't help me, Good Luck");

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (_timeSpan.TotalSeconds - 1 != 0)
            {
                _timeSpan -= TimeSpan.FromSeconds(1);
                TimerLbl.Text = _timeSpan.ToString("c");
            }
            else
            {
                _timer.Stop();
                _timer.Dispose();

                TimerLbl.Text = "Finished";
                MessageBox.Show("Sorry time finished, Quiz End.");
                QuizHelperPnl.Visible = false;

                SubmitBtn_Click(new object(), new EventArgs());
            }
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            if (_currentNumberOfQuestion - 1 < _questions.Count && _currentNumberOfQuestion - 1 > -1)
            {
                _examQuestions.ForEach(eQ => eQ.Visible = false);
                --_currentNumberOfQuestion;

                _examQuestions[_currentNumberOfQuestion].Visible = true;

                QuestionCounterLbl.Text = $"Question {_currentNumberOfQuestion + 1} of {_questions.Count}";

                Next.Visible = true;
            }

            if (_currentNumberOfQuestion - 1 == -1)
            {
                PrevBtn.Visible = false;
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {

            if (_currentNumberOfQuestion + 1 < _questions.Count && _currentNumberOfQuestion + 1 > -1)
            {
                _examQuestions.ForEach(eQ => eQ.Visible = false);
                ++_currentNumberOfQuestion;

                _examQuestions[_currentNumberOfQuestion].Visible = true;

                QuestionCounterLbl.Text = $"Question {_currentNumberOfQuestion + 1} of {_questions.Count}";
                PrevBtn.Visible = true;
            }

            if (_currentNumberOfQuestion + 1 == _questions.Count)
            {
                Next.Visible = false;
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            QuizHelperPnl.Visible = false;
            _timer.Stop();
            _timer.Dispose();


            int trueAnswers = 0;
            int emptyAnswers = 0;

            for (int i = 0; i < _examQuestions.Count; i++)
            {
                _examQuestions[i].ShowWrongOrRightChoiceToUser();

                try
                {
                    int option = _examQuestions[i].FindWhichOptionChoosed();
                    if (_examQuestions[i].Answers[option].IsCorrect == "Yes")
                        ++trueAnswers;
                }
                catch (InvalidOperationException)
                {
                    ++emptyAnswers;
                }
            }

            FinalForm finalForm = new FinalForm();
            var result = finalForm.ShowDialog(new List<string> { $"Correct answers count => {trueAnswers}",
                                                    $"Empty answers count => {emptyAnswers}",
                                                    $"Wrong answers count => {_questions.Count - trueAnswers - emptyAnswers}",
                                                    $"Result of {_questions.Count} questions"});

            finalForm.Close();
            finalForm.Dispose();

            Program.QuizUser.RightAnsweredQuestionNumber = trueAnswers;
            Program.QuizUser.EmptyAnsweredQuestionNumber = emptyAnswers;
            Program.QuizUser.WrongAnsweredQuestionNumber = _questions.Count - trueAnswers - emptyAnswers;
            Program.QuizUser.QuizQuestionCount = _questions.Count;


            #region Leaderboard

            if (!Directory.Exists("Leaderboard"))
                Directory.CreateDirectory("Leaderboard");

            List<QuizUser> quizUsers = new List<QuizUser>();
            JsonFileHelper.JSONDeSerialization(ref quizUsers, $"Leaderboard/{Program.QuizUser.QuizFileName}");
            int index = quizUsers.FindIndex(qU => qU.UsernameOrEmail == Program.QuizUser.UsernameOrEmail);

            if (index != QuizUserState.NotExist)
            {
                if (quizUsers[index].RightAnsweredQuestionNumber < Program.QuizUser.RightAnsweredQuestionNumber)
                {
                    quizUsers[index] = Program.QuizUser;
                }
            }
            else
                quizUsers.Add(Program.QuizUser);

            quizUsers.Sort
            (
                    (user1, user2) =>
                    {
                        return user2.RightAnsweredQuestionNumber.CompareTo(user1.RightAnsweredQuestionNumber);
                    }
            );


            JsonFileHelper.JSONSerialization(quizUsers, $"Leaderboard/{Program.QuizUser.QuizFileName}");

            #endregion


            SubmitBtn.Visible = false;
            BackToHomeBtn.Visible = true;

            var isUserWantsToSaveQuizResult = MessageBox.Show($"{Program.QuizUser.UsernameOrEmail} do you want to save your result in \".pdf\" file ?", "Examination ©", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);

            if (isUserWantsToSaveQuizResult == DialogResult.Yes)
            {
                Program.MainForm.Hide();

                SaveFileForm saveFileForm = new SaveFileForm();
                var formDoneItsJob = saveFileForm.ShowDialog();

                if (formDoneItsJob == DialogResult.OK || formDoneItsJob == DialogResult.Cancel)
                {
                    saveFileForm.Close();
                    saveFileForm.Dispose();
                }

                Program.MainForm.Show();

            }

            if (result == DialogResult.Cancel)
                Program.MainForm.ShowControl(new TakeExaminationControl());
        }

        private void BackToHomeBtn_Click(object sender, EventArgs e)
        {
            Program.MainForm.ShowControl(new TakeExaminationControl());
        }

        private void BackToHomeBtn_MouseHover(object sender, EventArgs e)
        {
            BackToHomeBtn.FillColor = ColorTranslator.FromHtml("#FFF689");
            BackToHomeBtn.ForeColor = ColorTranslator.FromHtml("#E03616");
        }

        private void BackToHomeBtn_MouseLeave(object sender, EventArgs e)
        {
            BackToHomeBtn.FillColor = Color.FromArgb(193, 140, 93);
            BackToHomeBtn.ForeColor = ColorTranslator.FromHtml("#FFFFFF");
        }


        #region Speech

        private void Default_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;

            if (speech == "Read question")
            {
                Lucy.SpeakAsync(_questions[_currentNumberOfQuestion].Text);
            }
            else if (speech == "Read option 1")
            {
                Lucy.SpeakAsync(_questions[_currentNumberOfQuestion].Answers[0].Text);
            }
            else if (speech == "Read option 2")
            {
                Lucy.SpeakAsync(_questions[_currentNumberOfQuestion].Answers[1].Text);
            }
            else if (speech == "Read option 3")
            {
                Lucy.SpeakAsync(_questions[_currentNumberOfQuestion].Answers[2].Text);
            }
            else if (speech == "Read last option")
            {
                Lucy.SpeakAsync(_questions[_currentNumberOfQuestion].Answers[3].Text);
            }
            else if (speech == "Next" && Next.Visible != false)
            {
                Next_Click(new object(), new EventArgs());
            }
            else if (speech == "Previous" && PrevBtn.Visible != false)
            {
                PrevBtn_Click(new object(), new EventArgs());
            }
            else if (speech == "Submit" && SubmitBtn.Visible != false)
            {
                SubmitBtn_Click(new object(), new EventArgs());
            }
            else if (speech == "Back to exams" && BackToHomeBtn.Visible != false)
            {
                BackToHomeBtn_Click(new object(), new EventArgs());
            }
            else if (speech == "Option 1" || speech == "Option 2" || speech == "Option 3" || speech == "Last option")
            {
                _examQuestions[_currentNumberOfQuestion].ChoicePickerWithSpeech(speech);
            }
            else if (speech == "Don't help me")
            {
                Lucy.SpeakAsync("Okay, Good Luck, if you need me just say, hey lucy");
                _recognizer.RecognizeAsyncCancel();
                _startListening.RecognizeAsync(RecognizeMode.Multiple);
            }
        }

        private void StartListening_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string speech = e.Result.Text;

            if (speech == "Hey lucy")
            {
                _startListening.RecognizeAsyncCancel();
                Lucy.SpeakAsync("Yes i am here");
                _recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }

        }

        #endregion


    }
}
