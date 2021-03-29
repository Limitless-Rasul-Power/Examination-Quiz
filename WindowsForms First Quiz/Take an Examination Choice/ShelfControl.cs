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
using WindowsForms_First_Quiz.Entity_Classes;
using WindowsForms_First_Quiz.File_Helper_Classes;

namespace WindowsForms_First_Quiz.Take_an_Examination_Choice
{
    public partial class ShelfControl : UserControl
    {
        private List<QuestionBlock> _questions = new List<QuestionBlock>();
        public string FileNameBtnText { get { return FileNameBtn.Text;  } set { FileNameBtn.Text = value; } }

        public ShelfControl()
        {
            InitializeComponent();
        }

        private void FileNameBtn_MouseHover(object sender, EventArgs e)
        {
            FileNameBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            FileNameBtn.FillColor = ColorTranslator.FromHtml("#F75C03");
            ExamPctBx.BackColor = ColorTranslator.FromHtml("#F75C03");
        }

        private void FileNameBtn_MouseLeave(object sender, EventArgs e)
        {
            FileNameBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            FileNameBtn.FillColor = ColorTranslator.FromHtml("#FFFFFF");
            ExamPctBx.BackColor = ColorTranslator.FromHtml("#FFFFFF");
        }

        private void FileNameBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("Questions"))
            {
                XMLFileHelper.XMLDeSerialize(ref _questions, $"Questions/{FileNameBtn.Text}");

                #region Imtahan verdiyi testlerin sadece adlarini yaziram

                List<string> assignedFileNames = new List<string>();

                JsonFileHelper.JSONDeSerialization(ref assignedFileNames, "Assigned Tests");

                if (!assignedFileNames.Contains(FileNameBtn.Text))
                {
                    assignedFileNames.Add(FileNameBtn.Text);
                }

                JsonFileHelper.JSONSerialization(assignedFileNames, "Assigned Tests");//bu ona goredir ki testlerin sayina gore leaderboard siyahisi qurum alt alta;//leaderboardentry - ye gore;

                #endregion

                Program.QuizUser.QuizFileName = FileNameBtn.Text;

                Program.MainForm.ShowControl(new ExaminationControl(_questions));

            }
        }
    }
}
