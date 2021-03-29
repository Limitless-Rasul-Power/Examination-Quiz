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

namespace WindowsForms_First_Quiz.LeaderBoard_Choice
{
    public partial class LeaderboardEntryControl : UserControl
    {
        private readonly List<LeaderboardTestNamesControl> _leaderboardTestNamesControls = new List<LeaderboardTestNamesControl>();
        private readonly int _currentPositionOfY = 132;
        
        public LeaderboardEntryControl()
        {
            InitializeComponent();

            List<string> assignedFileNames = new List<string>();
            JsonFileHelper.JSONDeSerialization(ref assignedFileNames, "Assigned Tests");


            for (int i = 0; i < assignedFileNames.Count; i++)
            {
                _leaderboardTestNamesControls.Add(new LeaderboardTestNamesControl());
                _leaderboardTestNamesControls[i].TestBtnText = assignedFileNames[i];
                _leaderboardTestNamesControls[i].Location = new Point(351, _currentPositionOfY);

                Controls.Add(_leaderboardTestNamesControls[i]);

                _currentPositionOfY += 80;
            }
        }

        private void GoBackPctBx_Click(object sender, EventArgs e)
        {
            Program.MainForm.ShowControl(new ExaminationHeadPageControl());
        }
    }
}
