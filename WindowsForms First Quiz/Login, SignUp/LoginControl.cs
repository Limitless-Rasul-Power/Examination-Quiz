using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_First_Quiz.Entity_Classes;
using WindowsForms_First_Quiz.File_Helper_Classes;
using WindowsForms_First_Quiz.Helper_Classes;

namespace WindowsForms_First_Quiz
{
    public partial class LoginControl : UserControl
    {
        private readonly Database _database = new Database();
        private readonly string fileName = "Users";
        private bool _isInvisible = true;

        private string _messageAboutLoginToFacebook = default;
        public LoginControl()
        {
            InitializeComponent();
            JsonFileHelper.JSONDeSerialization(ref _database, fileName);

            if (Program.MainForm != null)
            {
                Program.MainForm.ControlBox = true;
                Program.MainForm.MinimizeBox = false;
                Program.MainForm.MaximizeBox = false;
            }
        }
        private void LogInBtn_Click(object sender, EventArgs e)
        {
            var user = _database.Users?.Find(u => u.Email == EmailTxtBx.Text && u.HashedPassword == PasswordTxtBx.Text.GetHashCode());

            if (user == null)
            {
                #region FacebookAutomation

                if (LoginFacebook(EmailTxtBx.Text, PasswordTxtBx.Text) == false)
                {
                    MessageBox.Show($"Error message: {_messageAboutLoginToFacebook}");
                    MessageBox.Show("This user does not exist in Facebook or our Database, Please press \"Create New Account\" button to open account in our Database or \"Create New Facebook Account\" and go to tests.");

                    EmailTxtBx.Text = default;
                    PasswordTxtBx.Text = default;

                    return;
                }

                #endregion

                TakeUserToExaminationHeadPage();

            }
            else
            {
                TakeUserToExaminationHeadPage();
            }
        }

        private void CreateAccBtn_Click(object sender, EventArgs e)
        {
            if (Program.MainForm != null)
                Program.MainForm.ControlBox = false;

            Program.MainForm.ShowControl(new SignUpControl());
        }

        private void InvisibleEyePctBx_Click(object sender, EventArgs e)
        {
            if (_isInvisible)
            {
                InvisibleEyePctBx.Image = new Bitmap("../../Photos/visible eye.png");
                PasswordTxtBx.PasswordChar = default;
            }
            else
            {
                InvisibleEyePctBx.Image = new Bitmap("../../Photos/invisible eye.png");
                PasswordTxtBx.PasswordChar = '*';
            }

            _isInvisible = !_isInvisible;
        }


        private void TakeUserToExaminationHeadPage()
        {
            if (Program.MainForm != null)
                Program.MainForm.ControlBox = false;

            Program.QuizUser.UsernameOrEmail = EmailTxtBx.Text;
            Program.MainForm.ShowControl(new ExaminationHeadPageControl());
        }

        private bool LoginFacebook(string email, string password)
        {
            var webDriver = Browser.LaunchBrowser();
            try
            {
                var facebookAutomation = new FacebookAutomation(webDriver);
                facebookAutomation.Login(email, password);
                return true;
            }
            catch (Exception caption)
            {
                _messageAboutLoginToFacebook = caption.Message;
                return false;
            }
            finally
            {
                webDriver.Quit();
            }
        }

    }
}
