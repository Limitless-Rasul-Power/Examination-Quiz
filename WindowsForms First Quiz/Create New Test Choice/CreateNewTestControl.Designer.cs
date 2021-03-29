
namespace WindowsForms_First_Quiz
{
    partial class CreateNewTestControl
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
            this.EditByDragBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.DragFileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FileNameTxtBx = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.DontSaveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.FilePctBx = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CreateNewTestBtn = new Guna.UI2.WinForms.Guna2Button();
            this.GoBackPctBx = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FilePctBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoBackPctBx)).BeginInit();
            this.SuspendLayout();
            // 
            // EditByDragBtn
            // 
            this.EditByDragBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditByDragBtn.BorderRadius = 5;
            this.EditByDragBtn.CheckedState.Parent = this.EditByDragBtn;
            this.EditByDragBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditByDragBtn.CustomImages.Parent = this.EditByDragBtn;
            this.EditByDragBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(124)))), ((int)(((byte)(119)))));
            this.EditByDragBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.EditByDragBtn.ForeColor = System.Drawing.Color.White;
            this.EditByDragBtn.HoverState.Parent = this.EditByDragBtn;
            this.EditByDragBtn.Location = new System.Drawing.Point(454, 84);
            this.EditByDragBtn.Name = "EditByDragBtn";
            this.EditByDragBtn.ShadowDecoration.Parent = this.EditByDragBtn;
            this.EditByDragBtn.Size = new System.Drawing.Size(180, 45);
            this.EditByDragBtn.TabIndex = 1;
            this.EditByDragBtn.Text = "Edit by Dragging";
            this.EditByDragBtn.Click += new System.EventHandler(this.EditByDragBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveBtn.BorderRadius = 5;
            this.SaveBtn.CheckedState.Parent = this.SaveBtn;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.CustomImages.Parent = this.SaveBtn;
            this.SaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(138)))), ((int)(((byte)(21)))));
            this.SaveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.HoverState.Parent = this.SaveBtn;
            this.SaveBtn.Location = new System.Drawing.Point(768, 137);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.ShadowDecoration.Parent = this.SaveBtn;
            this.SaveBtn.Size = new System.Drawing.Size(151, 45);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DragFileBtn
            // 
            this.DragFileBtn.AllowDrop = true;
            this.DragFileBtn.BackColor = System.Drawing.Color.Transparent;
            this.DragFileBtn.BorderRadius = 5;
            this.DragFileBtn.BorderThickness = 2;
            this.DragFileBtn.CheckedState.Parent = this.DragFileBtn;
            this.DragFileBtn.CustomImages.Parent = this.DragFileBtn;
            this.DragFileBtn.FillColor = System.Drawing.Color.Red;
            this.DragFileBtn.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.DragFileBtn.ForeColor = System.Drawing.Color.White;
            this.DragFileBtn.HoverState.Parent = this.DragFileBtn;
            this.DragFileBtn.Location = new System.Drawing.Point(431, 176);
            this.DragFileBtn.Name = "DragFileBtn";
            this.DragFileBtn.ShadowDecoration.Parent = this.DragFileBtn;
            this.DragFileBtn.Size = new System.Drawing.Size(219, 89);
            this.DragFileBtn.TabIndex = 3;
            this.DragFileBtn.Text = "Drag files here to open tests.";
            this.DragFileBtn.Visible = false;
            this.DragFileBtn.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragFileBtn_DragDrop);
            this.DragFileBtn.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragFileBtn_DragEnter);
            this.DragFileBtn.DragLeave += new System.EventHandler(this.DragFileBtn_DragLeave);
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
            this.FileNameTxtBx.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FileNameTxtBx.ForeColor = System.Drawing.Color.Black;
            this.FileNameTxtBx.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FileNameTxtBx.HoverState.Parent = this.FileNameTxtBx;
            this.FileNameTxtBx.Location = new System.Drawing.Point(768, 84);
            this.FileNameTxtBx.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileNameTxtBx.Name = "FileNameTxtBx";
            this.FileNameTxtBx.PasswordChar = '\0';
            this.FileNameTxtBx.PlaceholderText = "File Name";
            this.FileNameTxtBx.SelectedText = "";
            this.FileNameTxtBx.ShadowDecoration.Parent = this.FileNameTxtBx;
            this.FileNameTxtBx.Size = new System.Drawing.Size(308, 36);
            this.FileNameTxtBx.TabIndex = 6;
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddBtn.CheckedState.Parent = this.AddBtn;
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.CustomImages.Parent = this.AddBtn;
            this.AddBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(122)))), ((int)(((byte)(75)))));
            this.AddBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.HoverState.Parent = this.AddBtn;
            this.AddBtn.Location = new System.Drawing.Point(318, 156);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.AddBtn.ShadowDecoration.Parent = this.AddBtn;
            this.AddBtn.Size = new System.Drawing.Size(81, 59);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add";
            this.AddBtn.Visible = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DontSaveBtn
            // 
            this.DontSaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.DontSaveBtn.BorderRadius = 5;
            this.DontSaveBtn.CheckedState.Parent = this.DontSaveBtn;
            this.DontSaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DontSaveBtn.CustomImages.Parent = this.DontSaveBtn;
            this.DontSaveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(29)))), ((int)(((byte)(54)))));
            this.DontSaveBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.DontSaveBtn.ForeColor = System.Drawing.Color.White;
            this.DontSaveBtn.HoverState.Parent = this.DontSaveBtn;
            this.DontSaveBtn.Location = new System.Drawing.Point(925, 137);
            this.DontSaveBtn.Name = "DontSaveBtn";
            this.DontSaveBtn.ShadowDecoration.Parent = this.DontSaveBtn;
            this.DontSaveBtn.Size = new System.Drawing.Size(151, 45);
            this.DontSaveBtn.TabIndex = 8;
            this.DontSaveBtn.Text = "Don\'t Save Changes";
            this.DontSaveBtn.Click += new System.EventHandler(this.DontSaveBtn_Click);
            // 
            // FilePctBx
            // 
            this.FilePctBx.BackColor = System.Drawing.Color.Transparent;
            this.FilePctBx.FillColor = System.Drawing.Color.Transparent;
            this.FilePctBx.Image = global::WindowsForms_First_Quiz.Properties.Resources.file;
            this.FilePctBx.Location = new System.Drawing.Point(524, 141);
            this.FilePctBx.Name = "FilePctBx";
            this.FilePctBx.ShadowDecoration.Parent = this.FilePctBx;
            this.FilePctBx.Size = new System.Drawing.Size(24, 24);
            this.FilePctBx.TabIndex = 4;
            this.FilePctBx.TabStop = false;
            this.FilePctBx.Visible = false;
            // 
            // CreateNewTestBtn
            // 
            this.CreateNewTestBtn.BackColor = System.Drawing.Color.Transparent;
            this.CreateNewTestBtn.BorderRadius = 5;
            this.CreateNewTestBtn.CheckedState.Parent = this.CreateNewTestBtn;
            this.CreateNewTestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateNewTestBtn.CustomImages.Parent = this.CreateNewTestBtn;
            this.CreateNewTestBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.CreateNewTestBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.CreateNewTestBtn.ForeColor = System.Drawing.Color.White;
            this.CreateNewTestBtn.HoverState.Parent = this.CreateNewTestBtn;
            this.CreateNewTestBtn.Location = new System.Drawing.Point(110, 84);
            this.CreateNewTestBtn.Name = "CreateNewTestBtn";
            this.CreateNewTestBtn.ShadowDecoration.Parent = this.CreateNewTestBtn;
            this.CreateNewTestBtn.Size = new System.Drawing.Size(180, 45);
            this.CreateNewTestBtn.TabIndex = 9;
            this.CreateNewTestBtn.Text = "Create New Test";
            this.CreateNewTestBtn.Click += new System.EventHandler(this.CreateNewTestBtn_Click);
            // 
            // GoBackPctBx
            // 
            this.GoBackPctBx.BackColor = System.Drawing.Color.Transparent;
            this.GoBackPctBx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GoBackPctBx.Image = global::WindowsForms_First_Quiz.Properties.Resources.left_arrow;
            this.GoBackPctBx.Location = new System.Drawing.Point(15, 20);
            this.GoBackPctBx.Name = "GoBackPctBx";
            this.GoBackPctBx.ShadowDecoration.Parent = this.GoBackPctBx;
            this.GoBackPctBx.Size = new System.Drawing.Size(39, 34);
            this.GoBackPctBx.TabIndex = 0;
            this.GoBackPctBx.TabStop = false;
            this.GoBackPctBx.Click += new System.EventHandler(this.GoBackPctBx_Click);
            // 
            // CreateNewTestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.GoBackPctBx);
            this.Controls.Add(this.CreateNewTestBtn);
            this.Controls.Add(this.DontSaveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.FileNameTxtBx);
            this.Controls.Add(this.FilePctBx);
            this.Controls.Add(this.DragFileBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.EditByDragBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "CreateNewTestControl";
            this.Size = new System.Drawing.Size(1118, 600);
            ((System.ComponentModel.ISupportInitialize)(this.FilePctBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoBackPctBx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button EditByDragBtn;
        private Guna.UI2.WinForms.Guna2Button SaveBtn;
        private Guna.UI2.WinForms.Guna2Button DragFileBtn;
        private Guna.UI2.WinForms.Guna2PictureBox FilePctBx;
        private Guna.UI2.WinForms.Guna2TextBox FileNameTxtBx;
        private Guna.UI2.WinForms.Guna2CircleButton AddBtn;
        private Guna.UI2.WinForms.Guna2Button DontSaveBtn;
        private Guna.UI2.WinForms.Guna2Button CreateNewTestBtn;
        private Guna.UI2.WinForms.Guna2PictureBox GoBackPctBx;
    }
}
