using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_First_Quiz.Entity_Classes;
using WindowsForms_First_Quiz.File_Helper_Classes;
using WindowsForms_First_Quiz.Static_Classes;
using System.IO;


namespace WindowsForms_First_Quiz.Take_an_Examination_Choice
{
    public partial class ExamQuestionsControl : UserControl
    {
        private Answer _firstAnswer;
        private Answer _secondAnswer;
        private Answer _thirdAnswer;
        private Answer _fourthAnswer;

        public readonly List<Answer> Answers = new List<Answer>();
        public readonly List<Guna.UI2.WinForms.Guna2PictureBox> Pictures = new List<Guna.UI2.WinForms.Guna2PictureBox>();

        
        public ExamQuestionsControl()
        {
            InitializeComponent();

            Pictures.Add(FirstAnswerPctBx);
            Pictures.Add(SecondAnswerPctBx);
            Pictures.Add(ThirdAnswerPctBx);
            Pictures.Add(FourthAnswerPctBx);                               
        }


        public int QuestionNumber
        {
            get { return int.Parse(QuestionNumberLbl.Text); }
            set { QuestionNumberLbl.Text = value.ToString(); }
        }

        public string Question
        {
            get { return QuestionLbl.Text; }
            set { QuestionLbl.Text = value.Trim(); }
        }

        public Answer FirstAnswer
        {
            get { return _firstAnswer; }
            set { _firstAnswer = value; FirstAnswerLbl.Text = value.Text; if (!Answers.Contains(value)) Answers.Add(_firstAnswer); }
        }

        public Answer SecondAnswer
        {
            get { return _secondAnswer; }
            set { _secondAnswer = value; SecondAnswerLbl.Text = value.Text; if (!Answers.Contains(value)) Answers.Add(_secondAnswer); }
        }

        public Answer ThirdAnswer
        {
            get { return _thirdAnswer; }
            set { _thirdAnswer = value; ThirdAnswerLbl.Text = value.Text; if (!Answers.Contains(value)) Answers.Add(_thirdAnswer); }
        }

        public Answer FourthAnswer
        {
            get { return _fourthAnswer; }
            set { _fourthAnswer = value; FourthAnswerLbl.Text = value.Text; if (!Answers.Contains(value)) Answers.Add(_fourthAnswer); }
        }


        public int FindWhichOptionChoosed()
        {
            if (FirstAnswerRdBtn.Checked)
                return QuestionChoices.FirstAnswer;
            else if (SecondAnswerRdBtn.Checked)
                return QuestionChoices.SecondAnswer;
            if (ThirdAnswerRdBtn.Checked)
                return QuestionChoices.ThirdAnswer;
            else if (FourthAnswerRdBtn.Checked)
                return QuestionChoices.FourthAnswer;

            throw new InvalidOperationException("Neither of them choosed.");
        }

        public void ShowWrongOrRightChoiceToUser()
        {
            Pictures.ForEach(p => p.Visible = true);

            for (int i = 0; i < Answers.Count; i++)
            {
                if (Answers[i].IsCorrect == "Yes")
                {
                    Pictures[i].Image = new Bitmap("../../Photos/right.png");
                }
            }   
        }

        #region Speech
        
        public void ChoicePickerWithSpeech(string choice)
        {            
            if (choice == "Option 1")
            {
                FirstAnswerRdBtn.Checked = true;
            }
            else if (choice == "Option 2")
            {
                SecondAnswerRdBtn.Checked = true;
            }
            else if (choice == "Option 3")
            {
                ThirdAnswerRdBtn.Checked = true;
            }
            else if (choice == "Last option")
            {
                FourthAnswerRdBtn.Checked = true;
            }
        }
        

        #endregion



    }
}
