using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_First_Quiz.Entity_Classes;

namespace WindowsForms_First_Quiz
{
    public partial class QuestionControl : UserControl
    {
        public QuestionControl()
        {
            InitializeComponent();
        }

        public int QuestionNumber
        {
            get { return int.Parse(QuestionNumberLbl.Text); }
            set { QuestionNumberLbl.Text = value.ToString(); }
        }
        public string Question
        {
            get { return QuestionTxtBx.Text; }
            set { QuestionTxtBx.Text = value; }
        }

        public Answer FirstAnswer
        {
            get { return new Answer { Text = FirstAnswerTxtBx.Text, IsCorrect = FirstRdBtn.Checked ? "Yes" : "No" }; }
            set { FirstAnswerTxtBx.Text = value.Text; FirstRdBtn.Checked = value.IsCorrect == "Yes"; }
        }

        public Answer SecondAnswer
        {
            get { return new Answer { Text = SecondAnswerTxtBx.Text, IsCorrect = SecondRdBtn.Checked ? "Yes" : "No" }; }
            set { SecondAnswerTxtBx.Text = value.Text; SecondRdBtn.Checked = value.IsCorrect == "Yes"; }
        }

        public Answer ThirdAnswer
        {
            get { return new Answer { Text = ThirdAnswerTxtBx.Text, IsCorrect = ThirdRdBtn.Checked ? "Yes" : "No" }; }
            set { ThirdAnswerTxtBx.Text = value.Text; ThirdRdBtn.Checked = value.IsCorrect == "Yes"; }
        }

        public Answer FourthAnswer
        {
            get { return new Answer { Text = FourthAnswerTxtBx.Text, IsCorrect = FourthRdBtn.Checked ? "Yes" : "No" }; }
            set { FourthAnswerTxtBx.Text = value.Text; FourthRdBtn.Checked = value.IsCorrect == "Yes"; }
        }


        public bool IsAllSquaresFilledUp()
        {
            return !(string.IsNullOrWhiteSpace(QuestionTxtBx.Text) || string.IsNullOrWhiteSpace(FirstAnswerTxtBx.Text)
                || string.IsNullOrWhiteSpace(SecondAnswerTxtBx.Text) || string.IsNullOrWhiteSpace(ThirdAnswerTxtBx.Text)
                || string.IsNullOrWhiteSpace(FourthAnswerTxtBx.Text));
        }

        public bool IsCorrectChoiceChoosen()
        {
            return FirstRdBtn.Checked || SecondRdBtn.Checked || ThirdRdBtn.Checked || FourthRdBtn.Checked;
        }

    }
}
