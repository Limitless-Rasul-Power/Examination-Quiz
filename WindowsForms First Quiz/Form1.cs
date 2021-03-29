using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_First_Quiz
{
    public partial class Form1 : Form
    {        
        private UserControl temp = new UserControl();

        public Form1()
        {
            InitializeComponent();
            ShowControl(new LoginControl());
        }

        public void ShowControl(UserControl control)
        {
            if (control != null && temp.GetType() != control.GetType())
            {
                Controls.Remove(temp);
                temp = control;
                Controls.Add(temp);
            }
        }

    }
}
