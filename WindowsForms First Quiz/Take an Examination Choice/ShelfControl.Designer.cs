
namespace WindowsForms_First_Quiz.Take_an_Examination_Choice
{
    partial class ShelfControl
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
            this.FileNameBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ExamPctBx = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExamPctBx)).BeginInit();
            this.SuspendLayout();
            // 
            // FileNameBtn
            // 
            this.FileNameBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(92)))), ((int)(((byte)(3)))));
            this.FileNameBtn.BorderRadius = 5;
            this.FileNameBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.FileNameBtn.BorderThickness = 1;
            this.FileNameBtn.CheckedState.Parent = this.FileNameBtn;
            this.FileNameBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileNameBtn.CustomImages.Parent = this.FileNameBtn;
            this.FileNameBtn.FillColor = System.Drawing.Color.White;
            this.FileNameBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.FileNameBtn.ForeColor = System.Drawing.Color.Black;
            this.FileNameBtn.HoverState.Parent = this.FileNameBtn;
            this.FileNameBtn.Location = new System.Drawing.Point(3, 12);
            this.FileNameBtn.Name = "FileNameBtn";
            this.FileNameBtn.ShadowDecoration.Parent = this.FileNameBtn;
            this.FileNameBtn.Size = new System.Drawing.Size(63, 227);
            this.FileNameBtn.TabIndex = 0;
            this.FileNameBtn.Text = "Example.xml";
            this.FileNameBtn.Click += new System.EventHandler(this.FileNameBtn_Click);
            this.FileNameBtn.MouseLeave += new System.EventHandler(this.FileNameBtn_MouseLeave);
            this.FileNameBtn.MouseHover += new System.EventHandler(this.FileNameBtn_MouseHover);
            // 
            // ExamPctBx
            // 
            this.ExamPctBx.BackColor = System.Drawing.Color.White;
            this.ExamPctBx.BorderRadius = 5;
            this.ExamPctBx.FillColor = System.Drawing.Color.Transparent;
            this.ExamPctBx.Image = global::WindowsForms_First_Quiz.Properties.Resources.test;
            this.ExamPctBx.Location = new System.Drawing.Point(21, 29);
            this.ExamPctBx.Name = "ExamPctBx";
            this.ExamPctBx.ShadowDecoration.Parent = this.ExamPctBx;
            this.ExamPctBx.Size = new System.Drawing.Size(27, 25);
            this.ExamPctBx.TabIndex = 1;
            this.ExamPctBx.TabStop = false;
            // 
            // ShelfControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.ExamPctBx);
            this.Controls.Add(this.FileNameBtn);
            this.Name = "ShelfControl";
            this.Size = new System.Drawing.Size(72, 251);
            ((System.ComponentModel.ISupportInitialize)(this.ExamPctBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button FileNameBtn;
        private Guna.UI2.WinForms.Guna2PictureBox ExamPctBx;
    }
}
