
namespace WindowsForms_First_Quiz.LeaderBoard_Choice
{
    partial class LeaderboardEntryControl
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
            this.LeaderTextLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ChooseLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.GoBackPctBx = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GoBackPctBx)).BeginInit();
            this.SuspendLayout();
            // 
            // LeaderTextLbl
            // 
            this.LeaderTextLbl.BackColor = System.Drawing.Color.Transparent;
            this.LeaderTextLbl.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LeaderTextLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(153)))), ((int)(((byte)(139)))));
            this.LeaderTextLbl.Location = new System.Drawing.Point(413, 34);
            this.LeaderTextLbl.Name = "LeaderTextLbl";
            this.LeaderTextLbl.Size = new System.Drawing.Size(244, 46);
            this.LeaderTextLbl.TabIndex = 0;
            this.LeaderTextLbl.Text = "Leaders are here.";
            // 
            // ChooseLbl
            // 
            this.ChooseLbl.BackColor = System.Drawing.Color.Transparent;
            this.ChooseLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(96)))), ((int)(((byte)(54)))));
            this.ChooseLbl.Location = new System.Drawing.Point(426, 78);
            this.ChooseLbl.Name = "ChooseLbl";
            this.ChooseLbl.Size = new System.Drawing.Size(212, 17);
            this.ChooseLbl.TabIndex = 3;
            this.ChooseLbl.Text = "Choose one of this files to see leaders.";
            // 
            // GoBackPctBx
            // 
            this.GoBackPctBx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackPctBx.Image = global::WindowsForms_First_Quiz.Properties.Resources.left_arrow;
            this.GoBackPctBx.Location = new System.Drawing.Point(16, 12);
            this.GoBackPctBx.Name = "GoBackPctBx";
            this.GoBackPctBx.ShadowDecoration.Parent = this.GoBackPctBx;
            this.GoBackPctBx.Size = new System.Drawing.Size(37, 32);
            this.GoBackPctBx.TabIndex = 4;
            this.GoBackPctBx.TabStop = false;
            this.GoBackPctBx.Click += new System.EventHandler(this.GoBackPctBx_Click);
            // 
            // LeaderboardEntryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GoBackPctBx);
            this.Controls.Add(this.ChooseLbl);
            this.Controls.Add(this.LeaderTextLbl);
            this.Name = "LeaderboardEntryControl";
            this.Size = new System.Drawing.Size(1118, 600);
            ((System.ComponentModel.ISupportInitialize)(this.GoBackPctBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel LeaderTextLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel ChooseLbl;
        private Guna.UI2.WinForms.Guna2PictureBox GoBackPctBx;
    }
}
