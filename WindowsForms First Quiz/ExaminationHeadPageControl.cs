using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_First_Quiz.LeaderBoard_Choice;

namespace WindowsForms_First_Quiz
{
    public partial class ExaminationHeadPageControl : UserControl
    {
        public ExaminationHeadPageControl()
        {
            InitializeComponent();
        }

        private void ConfigureWhenMouseHover(Guna.UI2.WinForms.Guna2Button button)
        {
            button.ForeColor = Color.White;
            button.FillColor = Color.FromArgb(236, 78, 32);
            button.BorderThickness = 1;
        }
        private void ConfigureWhenMouseLeave(Guna.UI2.WinForms.Guna2Button button)
        {
            button.ForeColor = Color.FromArgb(236, 78, 32);
            button.FillColor = Color.Transparent;
            button.BorderThickness = 3;
        }


        private void CreateNewTestBtn_MouseHover(object sender, EventArgs e)
        {
            ConfigureWhenMouseHover(CreateNewTestBtn);
        }

        private void CreateNewTestBtn_MouseLeave(object sender, EventArgs e)
        {
            ConfigureWhenMouseLeave(CreateNewTestBtn);
        }

        private void TakeExamBtn_MouseHover(object sender, EventArgs e)
        {
            ConfigureWhenMouseHover(TakeExamBtn);
        }

        private void TakeExamBtn_MouseLeave(object sender, EventArgs e)
        {
            ConfigureWhenMouseLeave(TakeExamBtn);
        }

        private void CreateNewTestBtn_Click(object sender, EventArgs e)
        {
            Program.MainForm.ShowControl(new CreateNewTestControl());
        }

        private void TakeExamBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("Questions"))
                Program.MainForm.ShowControl(new TakeExaminationControl());
            else
                MessageBox.Show("There is no Examination right now.");
        }

        private void ShowLeadersBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists("Assigned Tests.json"))
                Program.MainForm.ShowControl(new LeaderboardEntryControl());
            else
                MessageBox.Show("There is no assigned tests right now to have leaders.");
        }

        private void GoBackPctBx_Click(object sender, EventArgs e)
        {
            Program.MainForm.ShowControl(new LoginControl());
        }
    }
}
