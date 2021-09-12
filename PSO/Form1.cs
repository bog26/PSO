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
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != String.Empty)
            {
                OpenUserWindow(CheckForAdminRights(textBox2.Text));
            }
        }
        private bool CheckForAdminRights(string userName)
        {
            bool isAdmin = false;
            if(userName == "admin")
            {
                isAdmin = true;
            }
            return isAdmin;
        }
        private void OpenUserWindow(bool userHasAdminRights)
        {
            if(userHasAdminRights)
            {
                this.Hide();
                Form2 f2 = new Form2();
                //f2.Text = "Admin";
                f2.Show();
            }
            else 
            {
                this.Hide();
                Form3 f3 = new Form3();
                f3.Show();
            }
        }
        */


        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
