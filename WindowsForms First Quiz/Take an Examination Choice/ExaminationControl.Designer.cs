
namespace WindowsForms_First_Quiz.Take_an_Examination_Choice
{
    partial class ExaminationControl
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
            this.PrevBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Next = new Guna.UI2.WinForms.Guna2Button();
            this.SubmitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.QuestionCounterLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BackToHomeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.TimerLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.QuizTimeWordLbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.QuizHelperPnl = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.QuizHelperPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrevBtn
            // 
            this.PrevBtn.Animated = true;
            this.PrevBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(32)))));
            this.PrevBtn.BorderRadius = 5;
            this.PrevBtn.CheckedState.Parent = this.PrevBtn;
            this.PrevBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrevBtn.CustomImages.Parent = this.PrevBtn;
            this.PrevBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(161)))), ((int)(((byte)(32)))));
            this.PrevBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrevBtn.ForeColor = System.Drawing.Color.White;
            this.PrevBtn.HoverState.Parent = this.PrevBtn;
            this.PrevBtn.Location = new System.Drawing.Point(276, 525);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.ShadowDecoration.Parent = this.PrevBtn;
            this.PrevBtn.Size = new System.Drawing.Size(180, 45);
            this.PrevBtn.TabIndex = 0;
            this.PrevBtn.Text = "Previous";
            this.PrevBtn.Visible = false;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // Next
            // 
            this.Next.Animated = true;
            this.Next.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(196)))), ((int)(((byte)(138)))));
            this.Next.BorderRadius = 5;
            this.Next.CheckedState.Parent = this.Next;
            this.Next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Next.CustomImages.Parent = this.Next;
            this.Next.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(25)))), ((int)(((byte)(43)))));
            this.Next.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Next.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(196)))), ((int)(((byte)(138)))));
            this.Next.HoverState.Parent = this.Next;
            this.Next.Location = new System.Drawing.Point(541, 525);
            this.Next.Name = "Next";
            this.Next.ShadowDecoration.Parent = this.Next;
            this.Next.Size = new System.Drawing.Size(180, 45);
            this.Next.TabIndex = 1;
            this.Next.Text = "Next";
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Animated = true;
            this.SubmitBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.SubmitBtn.BorderRadius = 5;
            this.SubmitBtn.CheckedState.Parent = this.SubmitBtn;
            this.SubmitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SubmitBtn.CustomImages.Parent = this.SubmitBtn;
            this.SubmitBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(66)))), ((int)(((byte)(87)))));
            this.SubmitBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.HoverState.Parent = this.SubmitBtn;
            this.SubmitBtn.Location = new System.Drawing.Point(956, 525);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.ShadowDecoration.Parent = this.SubmitBtn;
            this.SubmitBtn.Size = new System.Drawing.Size(137, 45);
            this.SubmitBtn.TabIndex = 2;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // QuestionCounterLbl
            // 
            this.QuestionCounterLbl.BackColor = System.Drawing.Color.Transparent;
            this.QuestionCounterLbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionCounterLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(8)))), ((int)(((byte)(40)))));
            this.QuestionCounterLbl.Location = new System.Drawing.Point(21, 535);
            this.QuestionCounterLbl.Name = "QuestionCounterLbl";
            this.QuestionCounterLbl.Size = new System.Drawing.Size(66, 28);
            this.QuestionCounterLbl.TabIndex = 3;
            this.QuestionCounterLbl.Text = "Counter";
            // 
            // BackToHomeBtn
            // 
            this.BackToHomeBtn.Animated = true;
            this.BackToHomeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(140)))), ((int)(((byte)(93)))));
            this.BackToHomeBtn.CheckedState.Parent = this.BackToHomeBtn;
            this.BackToHomeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToHomeBtn.CustomImages.Parent = this.BackToHomeBtn;
            this.BackToHomeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(140)))), ((int)(((byte)(93)))));
            this.BackToHomeBtn.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F);
            this.BackToHomeBtn.ForeColor = System.Drawing.Color.White;
            this.BackToHomeBtn.HoverState.Parent = this.BackToHomeBtn;
            this.BackToHomeBtn.Location = new System.Drawing.Point(993, 0);
            this.BackToHomeBtn.Name = "BackToHomeBtn";
            this.BackToHomeBtn.ShadowDecoration.Parent = this.BackToHomeBtn;
            this.BackToHomeBtn.Size = new System.Drawing.Size(125, 45);
            this.BackToHomeBtn.TabIndex = 5;
            this.BackToHomeBtn.Text = "Back to exams";
            this.BackToHomeBtn.Visible = false;
            this.BackToHomeBtn.Click += new System.EventHandler(this.BackToHomeBtn_Click);
            this.BackToHomeBtn.MouseLeave += new System.EventHandler(this.BackToHomeBtn_MouseLeave);
            this.BackToHomeBtn.MouseHover += new System.EventHandler(this.BackToHomeBtn_MouseHover);
            // 
            // TimerLbl
            // 
            this.TimerLbl.BackColor = System.Drawing.Color.Transparent;
            this.TimerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerLbl.Location = new System.Drawing.Point(49, 68);
            this.TimerLbl.Name = "TimerLbl";
            this.TimerLbl.Size = new System.Drawing.Size(115, 35);
            this.TimerLbl.TabIndex = 6;
            this.TimerLbl.Text = "66:66:66";
            // 
            // QuizTimeWordLbl
            // 
            this.QuizTimeWordLbl.BackColor = System.Drawing.Color.Transparent;
            this.QuizTimeWordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuizTimeWordLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(68)))), ((int)(((byte)(48)))));
            this.QuizTimeWordLbl.Location = new System.Drawing.Point(37, 27);
            this.QuizTimeWordLbl.Name = "QuizTimeWordLbl";
            this.QuizTimeWordLbl.Size = new System.Drawing.Size(138, 35);
            this.QuizTimeWordLbl.TabIndex = 8;
            this.QuizTimeWordLbl.Text = "Quiz Time";
            // 
            // QuizHelperPnl
            // 
            this.QuizHelperPnl.BackColor = System.Drawing.Color.Transparent;
            this.QuizHelperPnl.Controls.Add(this.QuizTimeWordLbl);
            this.QuizHelperPnl.Controls.Add(this.TimerLbl);
            this.QuizHelperPnl.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(223)))), ((int)(((byte)(162)))));
            this.QuizHelperPnl.Location = new System.Drawing.Point(918, -1);
            this.QuizHelperPnl.Name = "QuizHelperPnl";
            this.QuizHelperPnl.ShadowColor = System.Drawing.Color.Black;
            this.QuizHelperPnl.Size = new System.Drawing.Size(200, 127);
            this.QuizHelperPnl.TabIndex = 9;
            // 
            // ExaminationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.QuizHelperPnl);
            this.Controls.Add(this.BackToHomeBtn);
            this.Controls.Add(this.QuestionCounterLbl);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.PrevBtn);
            this.Name = "ExaminationControl";
            this.Size = new System.Drawing.Size(1118, 600);
            this.QuizHelperPnl.ResumeLayout(false);
            this.QuizHelperPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button PrevBtn;
        private Guna.UI2.WinForms.Guna2Button Next;
        private Guna.UI2.WinForms.Guna2Button SubmitBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel QuestionCounterLbl;
        private Guna.UI2.WinForms.Guna2Button BackToHomeBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel TimerLbl;
        private Guna.UI2.WinForms.Guna2HtmlLabel QuizTimeWordLbl;
        private Guna.UI2.WinForms.Guna2ShadowPanel QuizHelperPnl;
    }
}
