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
    public partial class LeaderControl : UserControl
    {
        public int Place { get { return int.Parse(PlaceLbl.Text); } set { PlaceLbl.Text = value.ToString(); } }
        public string Username
        {
            get { return NameLbl.Text; }
            set 
            {
                if (value == "YOU")
                {
                    NameLbl.Font = new Font("Palatino Linotype", 26, FontStyle.Bold);
                    NameLbl.ForeColor = ColorTranslator.FromHtml("#FBB13C");
                    NameLbl.Location = new Point(73, 15);
                }
                NameLbl.Text = value;
            }
        }

        public int RightAnswersCount { get { return int.Parse(RightAnswersLbl.Text); } set { RightAnswersLbl.Text = value.ToString(); } }
        public int QuestionsCount { get { return int.Parse(QuestionCountLbl.Text); } set { QuestionCountLbl.Text = value.ToString(); } }

        public LeaderControl()
        {
            InitializeComponent();

            PlacementTlTp.SetToolTip(PlaceLbl, "Rank");
            UsernameTlTp.SetToolTip(NameLbl, "Username");
            RightAnswersTlTp.SetToolTip(RightAnswersLbl, "Correct Answers Count");
            QuestionCountTlTp.SetToolTip(QuestionCountLbl, "Questions Count");

        }


    }
}
