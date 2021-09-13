using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSO.Model;

namespace PSO
{
    public partial class Form3 : System.Windows.Forms.Form
    {
        private psDBContext psContext;
        public Form3()
        {
            InitializeComponent();
            psContext = new psDBContext();
            var admins = psContext.Admins.ToList();
            var clients = psContext.Clients.ToList();
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
            //CreateUser();
            bool completeUserData = CheckFillDataIntegrity();
            if (completeUserData)
            {
                MessageBox.Show("input data is correct");
            }
            else
            {
                MessageBox.Show("input data is wrong");
            }

            
        }
        public bool CheckFillDataIntegrity()
        {
            bool completeUserData = false;
            int StreetNr;
            int PostalCode;
            if (textBox1.Text != String.Empty
                && textBox2.Text != String.Empty
                && textBox3.Text != String.Empty
                && textBox4.Text != String.Empty
                && textBox5.Text != String.Empty
                && textBox6.Text != String.Empty
                && textBox8.Text != String.Empty
                && textBox10.Text != String.Empty
                && int.TryParse(textBox6.Text, out StreetNr)
                && int.TryParse(textBox10.Text, out PostalCode))
            {
                completeUserData = true;
            }
            return completeUserData;
        }



        public void CreateUser()
        {
            if(CheckIfUserIsAdmin())
            {
                Admin admin = new Admin(); //add arguments from text boxes
               
            }
            else
            {
                Client client = new Client(); //add arguments text boxes
            }
        }
        
        public bool CheckIfUserIsAdmin() 
        {
            bool isAdmin = false;

            // TBD: check if there is no admin in DB >> isAdmin = true
            return isAdmin;
        }

        public string GatherData(out UserPersonalData userInfo)
        {
            string name = String.Empty;
            userInfo = new UserPersonalData();

            return name;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
