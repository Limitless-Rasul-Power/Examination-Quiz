
namespace WindowsForms_First_Quiz
{
    partial class TakeExaminationControl
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GoBackPctBx = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GoBackPctBx)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(372, 27);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(552, 38);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "You are a CLICK away from the quiz";
            // 
            // GoBackPctBx
            // 
            this.GoBackPctBx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackPctBx.Image = global::WindowsForms_First_Quiz.Properties.Resources.left_arrow;
            this.GoBackPctBx.Location = new System.Drawing.Point(18, 27);
            this.GoBackPctBx.Name = "GoBackPctBx";
            this.GoBackPctBx.ShadowDecoration.Parent = this.GoBackPctBx;
            this.GoBackPctBx.Size = new System.Drawing.Size(36, 32);
            this.GoBackPctBx.TabIndex = 1;
            this.GoBackPctBx.TabStop = false;
            this.GoBackPctBx.Click += new System.EventHandler(this.GoBackPctBx_Click);
            // 
            // TakeExaminationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.GoBackPctBx);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "TakeExaminationControl";
            this.Size = new System.Drawing.Size(1118, 600);
            ((System.ComponentModel.ISupportInitialize)(this.GoBackPctBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox GoBackPctBx;
    }
}
