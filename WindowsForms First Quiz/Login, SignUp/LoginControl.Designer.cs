
namespace WindowsForms_First_Quiz
{
    partial class LoginControl
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
            this.EmailTxtBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTxtBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.LogInBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FirstPagePanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.InvisibleEyePctBx = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CreateAccBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.WelcomeLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.FirstPagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InvisibleEyePctBx)).BeginInit();
            this.SuspendLayout();
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
            this.EmailTxtBx.Location = new System.Drawing.Point(142, 27);
            this.EmailTxtBx.Name = "EmailTxtBx";
            this.EmailTxtBx.PasswordChar = '\0';
            this.EmailTxtBx.PlaceholderText = "Email or username";
            this.EmailTxtBx.SelectedText = "";
            this.EmailTxtBx.ShadowDecoration.Parent = this.EmailTxtBx;
            this.EmailTxtBx.Size = new System.Drawing.Size(200, 36);
            this.EmailTxtBx.TabIndex = 0;
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
            this.PasswordTxtBx.Location = new System.Drawing.Point(142, 85);
            this.PasswordTxtBx.Name = "PasswordTxtBx";
            this.PasswordTxtBx.PasswordChar = '*';
            this.PasswordTxtBx.PlaceholderText = "Password";
            this.PasswordTxtBx.SelectedText = "";
            this.PasswordTxtBx.ShadowDecoration.Parent = this.PasswordTxtBx;
            this.PasswordTxtBx.Size = new System.Drawing.Size(200, 36);
            this.PasswordTxtBx.TabIndex = 1;
            // 
            // LogInBtn
            // 
            this.LogInBtn.BorderRadius = 5;
            this.LogInBtn.CheckedState.Parent = this.LogInBtn;
            this.LogInBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInBtn.CustomImages.Parent = this.LogInBtn;
            this.LogInBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.LogInBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInBtn.ForeColor = System.Drawing.Color.White;
            this.LogInBtn.HoverState.Parent = this.LogInBtn;
            this.LogInBtn.Location = new System.Drawing.Point(142, 142);
            this.LogInBtn.Name = "LogInBtn";
            this.LogInBtn.ShadowDecoration.Parent = this.LogInBtn;
            this.LogInBtn.Size = new System.Drawing.Size(200, 37);
            this.LogInBtn.TabIndex = 2;
            this.LogInBtn.Text = "Log In";
            this.LogInBtn.Click += new System.EventHandler(this.LogInBtn_Click);
            // 
            // FirstPagePanel
            // 
            this.FirstPagePanel.BackColor = System.Drawing.Color.Transparent;
            this.FirstPagePanel.Controls.Add(this.InvisibleEyePctBx);
            this.FirstPagePanel.Controls.Add(this.CreateAccBtn);
            this.FirstPagePanel.Controls.Add(this.guna2Separator1);
            this.FirstPagePanel.Controls.Add(this.EmailTxtBx);
            this.FirstPagePanel.Controls.Add(this.LogInBtn);
            this.FirstPagePanel.Controls.Add(this.PasswordTxtBx);
            this.FirstPagePanel.FillColor = System.Drawing.Color.White;
            this.FirstPagePanel.Location = new System.Drawing.Point(336, 175);
            this.FirstPagePanel.Name = "FirstPagePanel";
            this.FirstPagePanel.Radius = 5;
            this.FirstPagePanel.ShadowColor = System.Drawing.Color.Black;
            this.FirstPagePanel.Size = new System.Drawing.Size(459, 286);
            this.FirstPagePanel.TabIndex = 3;
            // 
            // InvisibleEyePctBx
            // 
            this.InvisibleEyePctBx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InvisibleEyePctBx.Image = global::WindowsForms_First_Quiz.Properties.Resources.invisible_eye;
            this.InvisibleEyePctBx.Location = new System.Drawing.Point(353, 92);
            this.InvisibleEyePctBx.Name = "InvisibleEyePctBx";
            this.InvisibleEyePctBx.ShadowDecoration.Parent = this.InvisibleEyePctBx;
            this.InvisibleEyePctBx.Size = new System.Drawing.Size(27, 25);
            this.InvisibleEyePctBx.TabIndex = 5;
            this.InvisibleEyePctBx.TabStop = false;
            this.InvisibleEyePctBx.Click += new System.EventHandler(this.InvisibleEyePctBx_Click);
            // 
            // CreateAccBtn
            // 
            this.CreateAccBtn.BorderRadius = 5;
            this.CreateAccBtn.CheckedState.Parent = this.CreateAccBtn;
            this.CreateAccBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateAccBtn.CustomImages.Parent = this.CreateAccBtn;
            this.CreateAccBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(42)))));
            this.CreateAccBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.CreateAccBtn.ForeColor = System.Drawing.Color.White;
            this.CreateAccBtn.HoverState.Parent = this.CreateAccBtn;
            this.CreateAccBtn.Location = new System.Drawing.Point(164, 223);
            this.CreateAccBtn.Name = "CreateAccBtn";
            this.CreateAccBtn.ShadowDecoration.Parent = this.CreateAccBtn;
            this.CreateAccBtn.Size = new System.Drawing.Size(155, 42);
            this.CreateAccBtn.TabIndex = 4;
            this.CreateAccBtn.Text = "Create New Account";
            this.CreateAccBtn.Click += new System.EventHandler(this.CreateAccBtn_Click);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(91, 204);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(302, 10);
            this.guna2Separator1.TabIndex = 3;
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLbl.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(98)))), ((int)(((byte)(63)))));
            this.WelcomeLbl.Location = new System.Drawing.Point(408, 72);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(336, 34);
            this.WelcomeLbl.TabIndex = 4;
            this.WelcomeLbl.Text = "Welcome to Examination";
            // 
            // LoginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.WelcomeLbl);
            this.Controls.Add(this.FirstPagePanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LoginControl";
            this.Size = new System.Drawing.Size(1118, 600);
            this.FirstPagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InvisibleEyePctBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox EmailTxtBx;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTxtBx;
        private Guna.UI2.WinForms.Guna2Button LogInBtn;
        private Guna.UI2.WinForms.Guna2ShadowPanel FirstPagePanel;
        private Guna.UI2.WinForms.Guna2Button CreateAccBtn;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2PictureBox InvisibleEyePctBx;
        private Guna.UI2.WinForms.Guna2HtmlLabel WelcomeLbl;
    }
}
