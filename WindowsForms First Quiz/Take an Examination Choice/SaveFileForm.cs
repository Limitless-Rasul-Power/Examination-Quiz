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

namespace WindowsForms_First_Quiz.Take_an_Examination_Choice
{
    public partial class SaveFileForm : Form
    {        
        public SaveFileForm()
        {
            InitializeComponent();            
        }

        private void SaveBtn_MouseHover(object sender, EventArgs e)
        {
            SaveBtn.FillColor = ColorTranslator.FromHtml("#43B929");
        }

        private void SaveBtn_MouseLeave(object sender, EventArgs e)
        {
            SaveBtn.FillColor = ColorTranslator.FromHtml("#D69F7E");
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully saved.");
            PdfFileHelper.WriteUserResultToFile(Program.QuizUser, FileNameTxtBx.Text);

            this.DialogResult = DialogResult.OK;            
        }
    }
}
