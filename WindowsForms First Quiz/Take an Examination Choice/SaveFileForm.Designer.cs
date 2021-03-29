
namespace WindowsForms_First_Quiz.Take_an_Examination_Choice
{
    partial class SaveFileForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.FileNameTxtBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SuspendLayout();
            // 
            // FileNameTxtBx
            // 
            this.FileNameTxtBx.BorderRadius = 5;
            this.FileNameTxtBx.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FileNameTxtBx.DefaultText = "";
            this.FileNameTxtBx.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FileNameTxtBx.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FileNameTxtBx.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileNameTxtBx.DisabledState.Parent = this.FileNameTxtBx;
            this.FileNameTxtBx.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FileNameTxtBx.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FileNameTxtBx.FocusedState.Parent = this.FileNameTxtBx;
            this.FileNameTxtBx.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FileNameTxtBx.ForeColor = System.Drawing.Color.Black;
            this.FileNameTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FileNameTxtBx.HoverState.Parent = this.FileNameTxtBx;
            this.FileNameTxtBx.Location = new System.Drawing.Point(95, 31);
            this.FileNameTxtBx.Name = "FileNameTxtBx";
            this.FileNameTxtBx.PasswordChar = '\0';
            this.FileNameTxtBx.PlaceholderText = "File Name";
            this.FileNameTxtBx.SelectedText = "";
            this.FileNameTxtBx.ShadowDecoration.Parent = this.FileNameTxtBx;
            this.FileNameTxtBx.Size = new System.Drawing.Size(222, 41);
            this.FileNameTxtBx.TabIndex = 0;
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveBtn.CheckedState.Parent = this.SaveBtn;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.CustomImages.Parent = this.SaveBtn;
            this.SaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(159)))), ((int)(((byte)(126)))));
            this.SaveBtn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F);
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.HoverState.Parent = this.SaveBtn;
            this.SaveBtn.Location = new System.Drawing.Point(337, 80);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.SaveBtn.ShadowDecoration.Parent = this.SaveBtn;
            this.SaveBtn.Size = new System.Drawing.Size(66, 46);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            this.SaveBtn.MouseLeave += new System.EventHandler(this.SaveBtn_MouseLeave);
            this.SaveBtn.MouseHover += new System.EventHandler(this.SaveBtn_MouseHover);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_POSITIVE;
            this.guna2BorderlessForm1.BorderRadius = 5;
            this.guna2BorderlessForm1.ContainerControl = this;
            // 
            // SaveFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(6)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(415, 138);
            this.ControlBox = false;
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.FileNameTxtBx);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaveFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox FileNameTxtBx;
        private Guna.UI2.WinForms.Guna2CircleButton SaveBtn;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}