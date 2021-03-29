
namespace WindowsForms_First_Quiz.LeaderBoard_Choice
{
    partial class LeaderboardTestNamesControl
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
            this.TestBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // TestBtn
            // 
            this.TestBtn.Animated = true;
            this.TestBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(69)))), ((int)(((byte)(53)))));
            this.TestBtn.BorderRadius = 5;
            this.TestBtn.CheckedState.Parent = this.TestBtn;
            this.TestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TestBtn.CustomImages.Parent = this.TestBtn;
            this.TestBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(47)))), ((int)(((byte)(2)))));
            this.TestBtn.Font = new System.Drawing.Font("Lucida Handwriting", 12F);
            this.TestBtn.ForeColor = System.Drawing.Color.White;
            this.TestBtn.HoverState.Parent = this.TestBtn;
            this.TestBtn.Location = new System.Drawing.Point(3, 3);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.ShadowDecoration.Parent = this.TestBtn;
            this.TestBtn.Size = new System.Drawing.Size(384, 45);
            this.TestBtn.TabIndex = 0;
            this.TestBtn.Text = "0000-0000-0000-0000.xml";
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // LeaderboardTestNamesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TestBtn);
            this.Name = "LeaderboardTestNamesControl";
            this.Size = new System.Drawing.Size(392, 51);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button TestBtn;
    }
}
