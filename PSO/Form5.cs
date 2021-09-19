using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PSO.Model.FormElementsDisplay;
using static PSO.Model.DBBindings;
using PSO.Model;

namespace PSO
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }


        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        Label label5 = new Label();
        Label label6 = new Label();
        Label label7 = new Label();
        Label label8 = new Label();
        Label label9 = new Label();
        DataGridView dataGridView1 = new DataGridView();
        DataGridView dataGridView2 = new DataGridView();
        TextBox textBox1 = new TextBox();
        TextBox textBox2 = new TextBox();
        TextBox textBox3 = new TextBox(); //old pass
        TextBox textBox4 = new TextBox(); //new pass
        Button button11 = new Button();
        Button button12 = new Button();
        Button button13 = new Button();
        Button button14 = new Button();

        private void button3_Click(object sender, EventArgs e)
        {
            ShoWUserInformationFormElements();
            string loggedUser = ActiveForm.Text;
            DisplayNewLabel(label5, new int[2] { 230, 50 }, new int[2] { 168, 24 }, "Personal info");
            DisplayNewDataGridView(dataGridView1, new int[2] { 230, 90 }, new int[2] { 650, 45 });
            dataGridView1.DataSource = BindCrtUserDataToGrid(loggedUser);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

            DisplayNewLabel(label6, new int[2] { 230, 160 }, new int[2] { 168, 24 }, "Address");
            DisplayNewDataGridView(dataGridView2, new int[2] { 230, 200 }, new int[2] { 650, 45 });
            dataGridView2.DataSource = BindCrtUserAddressToGrid(loggedUser);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.CellContentClick += new DataGridViewCellEventHandler(dataGridView2_CellContentClick);

            DisplayNewLabel(label7, new int[2] { 950, 90 }, new int[2] { 168, 24 }, "Value");

            DisplayNewTextBox(textBox1, new int[2] { 950, 115 }, new int[2] { 60, 24 }, "Value");
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);

            DisplayNewButton(button11, new int[2] { 1030, 115 }, new int[2] { 60, 23 }, "button11", "Update");
            button11.Click += new EventHandler(button11_Click);


            DisplayNewLabel(label8, new int[2] { 950, 200 }, new int[2] { 168, 24 }, "Value");

            DisplayNewTextBox(textBox2, new int[2] { 950, 225 }, new int[2] { 60, 24 }, "Value");
            textBox2.TextChanged += new EventHandler(textBox2_TextChanged);

            DisplayNewButton(button12, new int[2] { 1030, 225 }, new int[2] { 60, 23 }, "button12", "Update");
            button12.Click += new EventHandler(button12_Click);

            DisplayNewLabel(label9, new int[2] { 230, 270 }, new int[2] { 168, 24 }, "Password");
            DisplayNewButton(button13, new int[2] { 230, 300 }, new int[2] { 120, 23 }, "button13", "Change Password");
            button13.Click += new EventHandler(button13_Click);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[e.ColumnIndex].Value != null && e.ColumnIndex >= 1)
            {
                string cellContent = dataGridView1.Rows[0].Cells[e.ColumnIndex].Value.ToString();
                textBox1.Text = cellContent;
                textBox1.Refresh();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[0].Cells[e.ColumnIndex].Value != null)
            {
                string cellContent = dataGridView2.Rows[0].Cells[e.ColumnIndex].Value.ToString();
                textBox2.Text = cellContent;
                textBox2.Refresh();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            int activeCellIndex = dataGridView1.CurrentCell.ColumnIndex;
            string activeColumn = dataGridView1.Columns[activeCellIndex].Name;
            //MessageBox.Show("cell column index:"+activeCellIndex);

            MessageBox.Show("updating " + activeColumn + " with " + value);
            DBUpdates.WriteUserPersonalDataToDB(activeColumn, value);
            dataGridView1.Refresh();
        }
        private void button12_Click(object sender, EventArgs e)
        {
            string value = textBox2.Text;
            int activeCellIndex = dataGridView2.CurrentCell.ColumnIndex;
            string activeColumn = dataGridView2.Columns[activeCellIndex].Name;

            MessageBox.Show("updating " + activeColumn + " with " + value);
            DBUpdates.WriteUserAddressToDB(activeColumn, value);
            dataGridView2.Refresh();
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox3.Show();
            textBox4.Show();
            button13.Show();
            DisplayNewTextBox(textBox3, new int[2] { 390, 270 }, new int[2] { 120, 24 }, "old password");
            textBox3.TextChanged += new EventHandler(textBox3_TextChanged);
            DisplayNewTextBox(textBox4, new int[2] { 390, 300 }, new int[2] { 120, 24 }, "new password");
            textBox4.TextChanged += new EventHandler(textBox4_TextChanged);

            DisplayNewButton(button14, new int[2] { 520, 270 }, new int[2] { 100, 22 }, "button14", "Update Password");
            button14.Click += new EventHandler(button14_Click);


        }
        private void button14_Click(object sender, EventArgs e)
        {
            if (InternalDBQueries.CheckForCorrectPassword(Form.ActiveForm.Text, textBox3.Text))
            {
                //MessageBox.Show("correct password");
                string newPassVal = textBox4.Text;
                DBUpdates.WriteNewPassToDB(newPassVal);
                MessageBox.Show("password changed");
            }
            else
            {
                MessageBox.Show("wrong password");
            }

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

        private void ShoWUserInformationFormElements()
        {
            label5.Show();
            dataGridView1.Show();
            textBox1.Show();
            textBox2.Show();
            label6.Show();
            dataGridView2.Show();
            label7.Show();
            label8.Show();
            button11.Show();
            label9.Show();
            button12.Show();
            button13.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HideUserInformationFormElements();
        }
        private void HideUserInformationFormElements()
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            button11.Hide();
            button12.Hide();
            button13.Hide();
            button14.Hide();
            
            
        }
    }
}
