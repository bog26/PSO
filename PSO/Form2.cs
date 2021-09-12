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
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private bool CheckForAdminRights(string userName)
        {
            bool isAdmin = false;
            if (userName == "admin")
            {
                isAdmin = true;
            }
            return isAdmin;
        }
        private void OpenUserWindow(bool userHasAdminRights)
        {
            if (userHasAdminRights)
            {
                this.Hide();
                Form4 f4 = new Form4();
                f4.Text = "Logged as: " + textBox1.Text;
                f4.Show();
            }
            else
            {
                this.Hide();
                Form5 f5 = new Form5();
                f5.Text = "Logged as: "+textBox1.Text;
                f5.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
            {
                OpenUserWindow(CheckForAdminRights(textBox1.Text));
            }
        }
    }
}
