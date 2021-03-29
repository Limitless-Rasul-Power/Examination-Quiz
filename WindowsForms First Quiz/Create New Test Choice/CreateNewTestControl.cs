using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_First_Quiz.Entity_Classes;
using WindowsForms_First_Quiz.File_Helper_Classes;
using WindowsForms_First_Quiz.Static_Classes;

namespace WindowsForms_First_Quiz
{
    public partial class CreateNewTestControl : UserControl
    {
        const int PositionOfX = 80;

        private List<QuestionBlock> _questions = new List<QuestionBlock>();
        private readonly List<QuestionControl> _questionControls = new List<QuestionControl>();
        private int _currentPositionOfY = 220;
        private readonly List<string> _testFileNames = new List<string>();
        public CreateNewTestControl()
        {
            InitializeComponent();
            JsonFileHelper.JSONDeSerialization(ref _testFileNames, "Test File Names");
            CreateContextMenu();
        }

        #region ContextMenuCreateComment

        private void CreateContextMenu()
        {
            ContextMenuStrip menuStrip = new ContextMenuStrip();

            List<ToolStripMenuItem> menuItems = new List<ToolStripMenuItem>
            {
                new ToolStripMenuItem("Create New Test"),
                new ToolStripMenuItem("Edit by Dragging"),
                new ToolStripMenuItem("Add"),
                new ToolStripMenuItem("Save"),
                new ToolStripMenuItem("Don\'t Save Changes")
            };

            menuItems[ContextMenuItemChoices.Add].Enabled = false;


            menuItems[ContextMenuItemChoices.CreateNewTest].Click += new EventHandler(CreateNewTestBtn_Click);
            menuItems[ContextMenuItemChoices.EditByDragging].Click += new EventHandler(EditByDragBtn_Click);
            menuItems[ContextMenuItemChoices.Add].Click += new EventHandler(AddBtn_Click);
            menuItems[ContextMenuItemChoices.Save].Click += new EventHandler(SaveBtn_Click);
            menuItems[ContextMenuItemChoices.DontSave].Click += new EventHandler(DontSaveBtn_Click);

            menuItems[ContextMenuItemChoices.CreateNewTest].ShortcutKeys = Keys.Control | Keys.C;
            menuItems[ContextMenuItemChoices.EditByDragging].ShortcutKeys = Keys.Control | Keys.E;
            menuItems[ContextMenuItemChoices.Add].ShortcutKeys = Keys.Control | Keys.A;
            menuItems[ContextMenuItemChoices.Save].ShortcutKeys = Keys.Control | Keys.S;
            menuItems[ContextMenuItemChoices.DontSave].ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;

            for (int i = 0; i < menuItems.Count; i++)
                menuStrip.Items.Add(menuItems[i]);


            this.ContextMenuStrip = menuStrip;
        }

        #endregion


        private void DragFileBtn_DragDrop(object sender, DragEventArgs e)
        {
            DragFileBtn.FillColor = Color.Red;
            DragFileBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            DragFileBtn.Text = "Drag files here to open tests.";
            DragFileBtn.Visible = false;

            FilePctBx.Visible = false;
            AddBtn.Visible = true;

            this.ContextMenuStrip.Items[ContextMenuItemChoices.Add].Enabled = true;

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            var sb = new StringBuilder();
            foreach (var item in files)
            {
                sb.Append(item);
            }

            XMLFileHelper.XMLDeSerialize(ref _questions, sb.ToString());


            for (int i = 0; i < _questions.Count; i++)
            {
                _questionControls.Add(new QuestionControl());
                _questionControls[i].QuestionNumber = i + 1;
                _questionControls[i].Question = _questions[i].Text;

                _questionControls[i].FirstAnswer = _questions[i].Answers[QuestionChoices.FirstAnswer];
                _questionControls[i].SecondAnswer = _questions[i].Answers[QuestionChoices.SecondAnswer];
                _questionControls[i].ThirdAnswer = _questions[i].Answers[QuestionChoices.ThirdAnswer];
                _questionControls[i].FourthAnswer = _questions[i].Answers[QuestionChoices.FourthAnswer];

                _questionControls[i].Location = new Point(PositionOfX, _currentPositionOfY);

                Controls.Add(_questionControls[i]);

                if (i + 1 < _questions.Count)
                    _currentPositionOfY += 333;

            }

        }
        private void DragFileBtn_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;

            DragFileBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            DragFileBtn.FillColor = Color.Green;
            DragFileBtn.Text = "Drop files to upload.";
        }

        private void DragFileBtn_DragLeave(object sender, EventArgs e)
        {
            DragFileBtn.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            DragFileBtn.FillColor = Color.Red;
            DragFileBtn.Text = "Drag files here to open tests.";
        }


        private void DisableButtonAndConfigureVisibilityAndEnableSaveBtn(Guna.UI2.WinForms.Guna2Button button, bool flag)
        {
            button.Enabled = false;
            DragFileBtn.Visible = flag;
            FilePctBx.Visible = flag;
            SaveBtn.Enabled = true;
        }

        private void CreateNewTestBtn_Click(object sender, EventArgs e)
        {
            DisableButtonAndConfigureVisibilityAndEnableSaveBtn(EditByDragBtn, false);

            AddBtn.Visible = true;

            this.ContextMenuStrip.Items[ContextMenuItemChoices.Add].Enabled = true;

            this.ContextMenuStrip.Items[ContextMenuItemChoices.EditByDragging].Enabled = false;
            this.ContextMenuStrip.Items[ContextMenuItemChoices.CreateNewTest].Enabled = false;

            _currentPositionOfY = 220;

            _questionControls.Add(new QuestionControl());
            _questionControls[_questionControls.Count - 1].Location = new Point(PositionOfX, _currentPositionOfY);
            _questionControls[_questionControls.Count - 1].QuestionNumber = _questionControls.Count;
            Controls.Add(_questionControls[_questionControls.Count - 1]);
        }

        private void EditByDragBtn_Click(object sender, EventArgs e)
        {
            DisableButtonAndConfigureVisibilityAndEnableSaveBtn(CreateNewTestBtn, true);
            AddBtn.Visible = false;

            this.ContextMenuStrip.Items[ContextMenuItemChoices.EditByDragging].Enabled = false;
            this.ContextMenuStrip.Items[ContextMenuItemChoices.CreateNewTest].Enabled = false;

            _currentPositionOfY = 220;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            bool isHasProblems = false;

            for (int i = 0; i < _questionControls.Count; i++)
            {                
                if (_questionControls[i].IsAllSquaresFilledUp() == false)
                {
                    isHasProblems = true;
                    MessageBox.Show($"You didn't fully fill up Question Number => \"{i + 1}\" .");
                    break;
                }
                else if (_questionControls[i].IsCorrectChoiceChoosen() == false)
                {
                    isHasProblems = true;
                    MessageBox.Show($"You didn't choose correct choice in Question Number => \"{i + 1}\" .");
                    break;
                }

            }

            if (isHasProblems == false)
            {
                _questionControls.ForEach(qc => Controls.Remove(qc));

                CreateNewTestBtn.Enabled = true;
                EditByDragBtn.Enabled = true;

                DragFileBtn.Visible = false;
                FilePctBx.Visible = false;

                AddBtn.Visible = false;

                for (int i = 0; i < this.ContextMenuStrip.Items.Count; i++)
                    this.ContextMenuStrip.Items[i].Enabled = true;

                this.ContextMenuStrip.Items[ContextMenuItemChoices.Add].Enabled = false;

                _currentPositionOfY = 220;


                _questions.Clear();
                for (int i = 0; i < _questionControls.Count; i++)
                {
                    _questions.Add(new QuestionBlock());
                    _questions[i].Text = _questionControls[i].Question;
                    _questions[i].Answers = new List<Answer> { _questionControls[i].FirstAnswer, _questionControls[i].SecondAnswer, _questionControls[i].ThirdAnswer, _questionControls[i].FourthAnswer };
                }


                if (_questionControls.Count > 0)
                {
                    string fileName = string.IsNullOrWhiteSpace(FileNameTxtBx.Text) ? $"test {Guid.NewGuid()}" : FileNameTxtBx.Text;
                    XMLFileHelper.XMLSerialize(_questions, fileName);

                    _testFileNames.Add($"{fileName}.xml");
                }
                else
                    MessageBox.Show("Didn't save because, didn't contains any question.");

                FileNameTxtBx.Text = default;

                _questionControls.Clear();
            }            
            
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.VerticalScroll.Value = 0;
            
            _currentPositionOfY += 333;

            _questionControls.Add(new QuestionControl());
            _questionControls[_questionControls.Count - 1].QuestionNumber = _questionControls.Count;
            _questionControls[_questionControls.Count - 1].Location = new Point(PositionOfX, _currentPositionOfY);

            Controls.Add(_questionControls[_questionControls.Count - 1]);
        }

        private void DontSaveBtn_Click(object sender, EventArgs e)
        {
            _questionControls.ForEach(qc => Controls.Remove(qc));
            _questionControls.Clear();
            _questions.Clear();

            EditByDragBtn.Enabled = true;
            CreateNewTestBtn.Enabled = true;


            DragFileBtn.Visible = false;
            FilePctBx.Visible = false;

            AddBtn.Visible = false;

            for (int i = 0; i < this.ContextMenuStrip.Items.Count; i++)            
                this.ContextMenuStrip.Items[i].Enabled = true;
            
            this.ContextMenuStrip.Items[ContextMenuItemChoices.Add].Enabled = false;


            FileNameTxtBx.Text = default;
            _currentPositionOfY = 220;
        }

        private void GoBackPctBx_Click(object sender, EventArgs e)
        {
            JsonFileHelper.JSONSerialization(_testFileNames, "Test File Names");
            Program.MainForm.ShowControl(new ExaminationHeadPageControl());
        }

   
    }
}
