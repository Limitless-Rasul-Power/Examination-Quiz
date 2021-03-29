using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_First_Quiz.LeaderBoard_Choice
{
    public partial class LeaderboardTestNamesControl : UserControl
    {        
        public LeaderboardTestNamesControl()
        {
            InitializeComponent();
        }

        public string TestBtnText
        {
            get { return TestBtn.Text; }
            set { TestBtn.Text = value; }
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            Program.MainForm.ShowControl(new PlacementControl(TestBtn.Text));
        }
    }
}
