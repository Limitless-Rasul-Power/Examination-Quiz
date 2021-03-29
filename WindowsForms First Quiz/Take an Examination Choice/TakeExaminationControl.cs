using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsForms_First_Quiz.File_Helper_Classes;
using WindowsForms_First_Quiz.Take_an_Examination_Choice;

namespace WindowsForms_First_Quiz
{
    public partial class TakeExaminationControl : UserControl
    {
        private readonly List<ShelfControl> _testShelfs = new List<ShelfControl>();
        private readonly List<string> _testFileNames = new List<string>();
        private readonly int _currentPositionOfX = 71;
        private readonly int _currentPositionOfY = 126;
        public TakeExaminationControl()
        {
            InitializeComponent();

            JsonFileHelper.JSONDeSerialization(ref _testFileNames, "Test File Names");

            for (int i = 0; i < _testFileNames.Count; i++)
            {
                _testShelfs.Add(new ShelfControl());
                _testShelfs[i].FileNameBtnText = _testFileNames[i];
                _testShelfs[i].Location = new Point(_currentPositionOfX, _currentPositionOfY);
                Controls.Add(_testShelfs[i]);

                if (i + 1 < _testFileNames.Count)
                {
                    _currentPositionOfX += 100; 
                }

                if ((i + 1) % 10 == 0)
                {
                    _currentPositionOfX = 71;
                    _currentPositionOfY += 254;;
                }

            }
        }

        private void GoBackPctBx_Click(object sender, EventArgs e)
        {
            Program.MainForm.ShowControl(new ExaminationHeadPageControl());
        }
    }
}

