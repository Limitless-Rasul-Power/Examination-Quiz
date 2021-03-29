
namespace WindowsForms_First_Quiz
{
    partial class SignUpControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SignUpPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.PasswordWarningLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.EmailWarningLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SignUpLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.GreetingLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SignUpBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ReplayPasswordTxtBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmailTxtBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTxtBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.GoBackPctBx = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SignUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoBackPctBx)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.BackColor = System.Drawing.Color.Transparent;
            this.SignUpPanel.Controls.Add(this.PasswordWarningLbl);
            this.SignUpPanel.Controls.Add(this.EmailWarningLbl);
            this.SignUpPanel.Controls.Add(this.SignUpLbl);
            this.SignUpPanel.Controls.Add(this.guna2Separator1);
            this.SignUpPanel.Controls.Add(this.GreetingLbl);
            this.SignUpPanel.Controls.Add(this.SignUpBtn);
            this.SignUpPanel.Controls.Add(this.ReplayPasswordTxtBx);
            this.SignUpPanel.Controls.Add(this.EmailTxtBx);
            this.SignUpPanel.Controls.Add(this.PasswordTxtBx);
            this.SignUpPanel.FillColor = System.Drawing.Color.White;
            this.SignUpPanel.Location = new System.Drawing.Point(336, 107);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Radius = 5;
            this.SignUpPanel.ShadowColor = System.Drawing.Color.Black;
            this.SignUpPanel.Size = new System.Drawing.Size(445, 386);
            this.SignUpPanel.TabIndex = 0;
            // 
            // PasswordWarningLbl
            // 
            this.PasswordWarningLbl.BackColor = System.Drawing.Color.Transparent;
            this.PasswordWarningLbl.ForeColor = System.Drawing.Color.Red;
            this.PasswordWarningLbl.Location = new System.Drawing.Point(126, 267);
            this.PasswordWarningLbl.Name = "PasswordWarningLbl";
            this.PasswordWarningLbl.Size = new System.Drawing.Size(278, 15);
            this.PasswordWarningLbl.TabIndex = 8;
            this.PasswordWarningLbl.Text = "Replay password doesn\'t compatible with upper password.";
            this.PasswordWarningLbl.Visible = false;
            // 
            // EmailWarningLbl
            // 
            this.EmailWarningLbl.BackColor = System.Drawing.Color.Transparent;
            this.EmailWarningLbl.ForeColor = System.Drawing.Color.Red;
            this.EmailWarningLbl.Location = new System.Drawing.Point(126, 150);
            this.EmailWarningLbl.Name = "EmailWarningLbl";
            this.EmailWarningLbl.Size = new System.Drawing.Size(134, 15);
            this.EmailWarningLbl.TabIndex = 7;
            this.EmailWarningLbl.Text = "This user email already exist";
            this.EmailWarningLbl.Visible = false;
            // 
            // SignUpLbl
            // 
            this.SignUpLbl.BackColor = System.Drawing.Color.Transparent;
            this.SignUpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignUpLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(30)))), ((int)(((byte)(33)))));
            this.SignUpLbl.Location = new System.Drawing.Point(24, 20);
            this.SignUpLbl.Name = "SignUpLbl";
            this.SignUpLbl.Size = new System.Drawing.Size(86, 27);
            this.SignUpLbl.TabIndex = 6;
            this.SignUpLbl.Text = "Sign Up";
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(3, 81);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(436, 10);
            this.guna2Separator1.TabIndex = 5;
            // 
            // GreetingLbl
            // 
            this.GreetingLbl.BackColor = System.Drawing.Color.Transparent;
            this.GreetingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GreetingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(103)))), ((int)(((byte)(112)))));
            this.GreetingLbl.Location = new System.Drawing.Point(24, 57);
            this.GreetingLbl.Name = "GreetingLbl";
            this.GreetingLbl.Size = new System.Drawing.Size(116, 18);
            this.GreetingLbl.TabIndex = 4;
            this.GreetingLbl.Text = "It\'s quick and easy.";
            // 
            // SignUpBtn
            // 
            this.SignUpBtn.BorderRadius = 5;
            this.SignUpBtn.CheckedState.Parent = this.SignUpBtn;
            this.SignUpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpBtn.CustomImages.Parent = this.SignUpBtn;
            this.SignUpBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(42)))));
            this.SignUpBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.SignUpBtn.ForeColor = System.Drawing.Color.White;
            this.SignUpBtn.HoverState.Parent = this.SignUpBtn;
            this.SignUpBtn.Location = new System.Drawing.Point(124, 295);
            this.SignUpBtn.Name = "SignUpBtn";
            this.SignUpBtn.ShadowDecoration.Parent = this.SignUpBtn;
            this.SignUpBtn.Size = new System.Drawing.Size(200, 40);
            this.SignUpBtn.TabIndex = 3;
            this.SignUpBtn.Text = "Sign Up";
            this.SignUpBtn.Click += new System.EventHandler(this.SignUpBtn_Click);
            // 
            // ReplayPasswordTxtBx
            // 
            this.ReplayPasswordTxtBx.Animated = true;
            this.ReplayPasswordTxtBx.BackColor = System.Drawing.Color.White;
            this.ReplayPasswordTxtBx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.ReplayPasswordTxtBx.BorderRadius = 5;
            this.ReplayPasswordTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReplayPasswordTxtBx.DefaultText = "";
            this.ReplayPasswordTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ReplayPasswordTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ReplayPasswordTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReplayPasswordTxtBx.DisabledState.Parent = this.ReplayPasswordTxtBx;
            this.ReplayPasswordTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReplayPasswordTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReplayPasswordTxtBx.FocusedState.Parent = this.ReplayPasswordTxtBx;
            this.ReplayPasswordTxtBx.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.ReplayPasswordTxtBx.ForeColor = System.Drawing.Color.Black;
            this.ReplayPasswordTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReplayPasswordTxtBx.HoverState.Parent = this.ReplayPasswordTxtBx;
            this.ReplayPasswordTxtBx.Location = new System.Drawing.Point(124, 225);
            this.ReplayPasswordTxtBx.Name = "ReplayPasswordTxtBx";
            this.ReplayPasswordTxtBx.PasswordChar = '*';
            this.ReplayPasswordTxtBx.PlaceholderText = "Write Password Again";
            this.ReplayPasswordTxtBx.SelectedText = "";
            this.ReplayPasswordTxtBx.ShadowDecoration.Parent = this.ReplayPasswordTxtBx;
            this.ReplayPasswordTxtBx.Size = new System.Drawing.Size(200, 36);
            this.ReplayPasswordTxtBx.TabIndex = 2;
            // 
            // EmailTxtBx
            // 
            this.EmailTxtBx.Animated = true;
            this.EmailTxtBx.BackColor = System.Drawing.Color.White;
            this.EmailTxtBx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.EmailTxtBx.BorderRadius = 5;
            this.EmailTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTxtBx.DefaultText = "";
            this.EmailTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxtBx.DisabledState.Parent = this.EmailTxtBx;
            this.EmailTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxtBx.FocusedState.Parent = this.EmailTxtBx;
            this.EmailTxtBx.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.EmailTxtBx.ForeColor = System.Drawing.Color.Black;
            this.EmailTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTxtBx.HoverState.Parent = this.EmailTxtBx;
            this.EmailTxtBx.Location = new System.Drawing.Point(124, 114);
            this.EmailTxtBx.Name = "EmailTxtBx";
            this.EmailTxtBx.PasswordChar = '\0';
            this.EmailTxtBx.PlaceholderText = "Email or username";
            this.EmailTxtBx.SelectedText = "";
            this.EmailTxtBx.ShadowDecoration.Parent = this.EmailTxtBx;
            this.EmailTxtBx.Size = new System.Drawing.Size(200, 36);
            this.EmailTxtBx.TabIndex = 0;
            this.EmailTxtBx.TextChanged += new System.EventHandler(this.EmailTxtBx_TextChanged);
            // 
            // PasswordTxtBx
            // 
            this.PasswordTxtBx.Animated = true;
            this.PasswordTxtBx.BackColor = System.Drawing.Color.White;
            this.PasswordTxtBx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(226)))));
            this.PasswordTxtBx.BorderRadius = 5;
            this.PasswordTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTxtBx.DefaultText = "";
            this.PasswordTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxtBx.DisabledState.Parent = this.PasswordTxtBx;
            this.PasswordTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxtBx.FocusedState.Parent = this.PasswordTxtBx;
            this.PasswordTxtBx.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.PasswordTxtBx.ForeColor = System.Drawing.Color.Black;
            this.PasswordTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTxtBx.HoverState.Parent = this.PasswordTxtBx;
            this.PasswordTxtBx.Location = new System.Drawing.Point(124, 172);
            this.PasswordTxtBx.Name = "PasswordTxtBx";
            this.PasswordTxtBx.PasswordChar = '*';
            this.PasswordTxtBx.PlaceholderText = "Password";
            this.PasswordTxtBx.SelectedText = "";
            this.PasswordTxtBx.ShadowDecoration.Parent = this.PasswordTxtBx;
            this.PasswordTxtBx.Size = new System.Drawing.Size(200, 36);
            this.PasswordTxtBx.TabIndex = 1;
            // 
            // GoBackPctBx
            // 
            this.GoBackPctBx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackPctBx.Image = global::WindowsForms_First_Quiz.Properties.Resources.left_arrow;
            this.GoBackPctBx.Location = new System.Drawing.Point(15, 17);
            this.GoBackPctBx.Name = "GoBackPctBx";
            this.GoBackPctBx.ShadowDecoration.Parent = this.GoBackPctBx;
            this.GoBackPctBx.Size = new System.Drawing.Size(38, 33);
            this.GoBackPctBx.TabIndex = 1;
            this.GoBackPctBx.TabStop = false;
            this.GoBackPctBx.Click += new System.EventHandler(this.GoBackPctBx_Click);
            // 
            // SignUpControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.GoBackPctBx);
            this.Controls.Add(this.SignUpPanel);
            this.Name = "SignUpControl";
            this.Size = new System.Drawing.Size(1118, 600);
            this.Load += new System.EventHandler(this.SignUpControl_Load);
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoBackPctBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel SignUpPanel;
        private Guna.UI2.WinForms.Guna2TextBox EmailTxtBx;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxtBx;
        private Guna.UI2.WinForms.Guna2Button SignUpBtn;
        private Guna.UI2.WinForms.Guna2TextBox ReplayPasswordTxtBx;
        private Guna.UI2.WinForms.Guna2HtmlLabel SignUpLbl;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2HtmlLabel GreetingLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel EmailWarningLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel PasswordWarningLbl;
        private Guna.UI2.WinForms.Guna2PictureBox GoBackPctBx;
    }
}
