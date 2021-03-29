using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WindowsForms_First_Quiz.Entity_Classes;
using WindowsForms_First_Quiz.Take_an_Examination_Choice;

namespace WindowsForms_First_Quiz
{
    public static class Program
    {
        private static Form1 form1;
        private static QuizUser quizUser;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            quizUser = new QuizUser();

            form1 = new Form1();
            Application.Run(form1);
        }

        public static QuizUser QuizUser
        {
            get { return quizUser; }
        }
        public static Form1 MainForm
        {
            get { return form1; }
        }


    }
}
