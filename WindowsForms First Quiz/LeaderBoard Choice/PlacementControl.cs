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

namespace WindowsForms_First_Quiz.LeaderBoard_Choice
{
    public partial class PlacementControl : UserControl
    {
        private readonly List<QuizUser> _leaders = new List<QuizUser>();
        private readonly List<LeaderControl> _leaderControls = new List<LeaderControl>();
        private readonly int _currentPositionOfY = 181;
        public PlacementControl()
        {
            InitializeComponent();
        }

        public PlacementControl(string fileName)
        {
            InitializeComponent();

            if (!string.IsNullOrWhiteSpace(fileName))
            {
                JsonFileHelper.JSONDeSerialization(ref _leaders, $"Leaderboard/{fileName}");

                for (int i = 0; i < _leaders.Count; i++)
                {
                    _leaderControls.Add(new LeaderControl());

                    _leaderControls[i].Place = i + 1;

                    if (_leaders[i].UsernameOrEmail == Program.QuizUser.UsernameOrEmail)
                    {
                        _leaderControls[i].Username = "YOU";
                    }
                    else
                    {
                        _leaderControls[i].Username = _leaders[i].UsernameOrEmail; 
                    }

                    _leaderControls[i].RightAnswersCount = _leaders[i].RightAnsweredQuestionNumber;
                    _leaderControls[i].QuestionsCount = _leaders[i].QuizQuestionCount;

                    _leaderControls[i].Location = new Point(170, _currentPositionOfY);

                    Controls.Add(_leaderControls[i]);

                    _currentPositionOfY += 137;
                }

            }

        }

        private void GoBackPctBx_Click(object sender, EventArgs e)
        {
            Program.MainForm.ShowControl(new LeaderboardEntryControl());
        }
    }
}
