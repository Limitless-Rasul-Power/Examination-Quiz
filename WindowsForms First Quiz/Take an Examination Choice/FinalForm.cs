using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_First_Quiz.Static_Classes;

namespace WindowsForms_First_Quiz.Take_an_Examination_Choice
{
    public partial class FinalForm : Form
    {
        public FinalForm()
        {
            InitializeComponent();            
        }

        public DialogResult ShowDialog(List<string> results)
        {
            if (results != null)
            {
                RightAnswersLbl.Text = results[Results.RightAnswerCount];
                EmptyAnswersLbl.Text = results[Results.EmptyAnswerCount];
                WrongAnswersLbl.Text = results[Results.WrongAnswerCount];
                QuestionCountLbl.Text = results[Results.QuestionCount];
            }

            return ShowDialog();
        }

        private void BackHomeBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void LookAnswersBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
