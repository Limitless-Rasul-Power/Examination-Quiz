using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_First_Quiz.Entity_Classes
{
    public class QuizUser
    {
        public string UsernameOrEmail { get; set; }
        public int RightAnsweredQuestionNumber { get; set; }
        public int EmptyAnsweredQuestionNumber { get; set; }
        public int WrongAnsweredQuestionNumber { get; set; }

        public int QuizQuestionCount { get; set; }
        public string QuizFileName { get; set; }
    }
}
