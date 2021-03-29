using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms_First_Quiz.Custom_Exception_Classes
{
    public class LoginNotSuccessfullException : ApplicationException
    {        

        public LoginNotSuccessfullException()
            :base("Login not successfull.")
        {            
        }

        public LoginNotSuccessfullException(string message)
            :base(message)
        {            
        }


    }
}
