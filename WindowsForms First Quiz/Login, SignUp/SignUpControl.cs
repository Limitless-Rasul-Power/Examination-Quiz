using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_First_Quiz.File_Helper_Classes;

namespace WindowsForms_First_Quiz
{
    public partial class SignUpControl : UserControl
    {
        private readonly Database _database = new Database();
        private readonly string fileName = "Users";
        private bool isUserExist = false;
        public SignUpControl()
        {
            InitializeComponent();
            JsonFileHelper.JSONDeSerialization(ref _database, fileName);
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            if (isUserExist)
            {
                MessageBox.Show($"This => {EmailTxtBx.Text} email or username already exists.");
                EmailTxtBx.Text = default;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(PasswordTxtBx.Text))
                {
                    MessageBox.Show("Password can not be only white space.");
                    PasswordTxtBx.Text = default;
                    ReplayPasswordTxtBx.Text = default;                        
                }
                else if (string.IsNullOrWhiteSpace(EmailTxtBx.Text))
                {
                    MessageBox.Show("Email(username) can not be only white space.");
                    EmailTxtBx.Text = default;
                }
                else if (PasswordTxtBx.Text != ReplayPasswordTxtBx.Text)
                {
                    PasswordWarningLbl.Visible = true;
                }
                else
                {
                    _database.Users.Add(new User { Email = EmailTxtBx.Text.Trim(), HashedPassword = PasswordTxtBx.Text.Trim().GetHashCode() });
                    JsonFileHelper.JSONSerialization(_database, fileName);

                    PasswordWarningLbl.Visible = false;                    

                    MessageBox.Show("Successfully Sign Up");

                    Program.MainForm.ShowControl(new LoginControl());
                }                
            }
        }

        private void EmailTxtBx_TextChanged(object sender, EventArgs e)
        {
            var user = _database.Users?.Find(u => u.Email == EmailTxtBx.Text);

            if (user != null)
            {
                ConfigureWhenUserEntersEmail(true);                
            }
            else
            {
                ConfigureWhenUserEntersEmail(false);
            }
        }

        private void ConfigureWhenUserEntersEmail(bool flag)
        {
            EmailWarningLbl.Visible = flag;
            isUserExist = flag;
        }

        private void GoBackPctBx_Click(object sender, EventArgs e)
        {
            Program.MainForm.ShowControl(new LoginControl());
        }

        private void SignUpControl_Load(object sender, EventArgs e)
        {
            MessageBox.Show(@"Starting and ending spaces in the either email(username) or password are ignored, be aware of this.
                                                                                   Thank you for reading.", "Our Terms");
        }
    }
}
