using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSO
{
    public partial class Form3 : System.Windows.Forms.Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateUser();
        }

        public void CreateUser()
        {
            if(CheckIfUserIsAdmin())
            {

                Model.Admin admin = new Model.Admin(); //add arguments
               
            }
            else
            {
                Model.Client client = new Model.Client(); //add arguments
            }
        }
        
        public bool CheckIfUserIsAdmin() 
        {
            
            bool isAdmin = false;
            // TBD: check if there is no admin in DB >> isAdmin = true
            return isAdmin;
        }
    }
}
