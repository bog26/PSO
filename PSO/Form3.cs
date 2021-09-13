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
            //var admins = psContext.Admins.ToList();
            //var clients = psContext.Clients.ToList();
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
            //bool completeUserData = CheckFillDataCorrectness();
            if (CheckFillDataCorrectness())
            {
                MessageBox.Show("input data is correct." );
                if (CheckForExistingAdmin())    
                {
                    CreateAdmin();
                    MessageBox.Show("Admin account succesfully created");
                }
                else
                {
                    CreateClient();
                    MessageBox.Show("Client account succesfully created");
                }
            }
            else
            {
                MessageBox.Show("input data is wrong");
            }

        }
        public bool CheckFillDataCorrectness()
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
                && textBox11.Text != String.Empty
                && int.TryParse(textBox6.Text, out StreetNr)
                && int.TryParse(textBox10.Text, out PostalCode))
            {
                completeUserData = true;
            }
            return completeUserData;
        }

        public bool CheckForExistingAdmin()
        {
            bool existingAdmin = false;
            var admins = psContext.Admins.ToList();
            if (admins.Count != 0)
            {
                existingAdmin = true;
            }
            MessageBox.Show("existing admins: "+ admins.Count);
            return existingAdmin;
        }
        public void CreateAdmin()
        {
            var newAdmin = new Admin();
            UserPersonalData userPersonalData = GatherUserData();
            newAdmin.UserName = textBox1.Text;
            newAdmin.AdminPersonalData = userPersonalData;

            //test:
            MessageBox.Show("Testing new admin data: " + newAdmin.AdminPersonalData.FirstName + " "
                + newAdmin.AdminPersonalData.LastName);
        }

        public void CreateClient()
        {
            var newClient = new Client();
            UserPersonalData userPersonalData = GatherUserData();
            newClient.UserName = textBox1.Text;
            newClient.ClientPersonalData = userPersonalData;

            //test:
            MessageBox.Show("Testing new client data: " + newClient.ClientPersonalData.FirstName + " "
                + newClient.ClientPersonalData.LastName);
        }
        public UserPersonalData GatherUserData()
        {
            var userAddress = new UserAddress
            {
                Street = textBox5.Text,
                StreetNr = int.Parse(textBox6.Text),
                City = textBox7.Text,
                Region = textBox8.Text,
                Country = textBox9.Text,
                PostalCode = int.Parse(textBox10.Text)
            };

            string userBirthDateStr = monthCalendar1.SelectionRange.Start.ToShortDateString();
            DateTime userBirthDate = Convert.ToDateTime(userBirthDateStr);

            //MessageBox.Show(clientBirthDate.ToShortDateString());  //ok

            var userPersonalData = new UserPersonalData
            {
                FirstName = textBox2.Text,
                LastName = textBox3.Text,
                BirthDate = userBirthDate,
                Email = textBox4.Text,
                Telephone = textBox11.Text,
                Address = userAddress
            };
            return userPersonalData;

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

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
