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
    public partial class Form4 : Form
    {
        //private psDBContext psContext;
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            bool executedFromAdminAccount = true;
            Form3 f3 = new Form3(executedFromAdminAccount);
            f3.Show();
        }
        DataGridView dataGridView1 = new DataGridView();
        DataGridView dataGridView2 = new DataGridView();
        TextBox textBox1 = new TextBox();
        Label label5 = new Label();
        Label label6 = new Label();
        Label label7 = new Label();
        Button button15 = new Button();

        private void button4_Click(object sender, EventArgs e)
        {
            ShoWUserInformationFormElements();

            string loggedUser = ActiveForm.Text;
            //DisplayNewLabel(label15, new int[2] { 230, 50 }, new int[2] { 168, 24 }, "User info");
            DisplayNewLabel(label5, new int[2] { 230, 50 }, new int[2] { 168, 24 }, loggedUser + " - personal info");
            DisplayNewDataGridView(dataGridView1, new int[2] { 230, 90 }, new int[2] { 650, 45 });
            dataGridView1.DataSource = BindCrtUserDataToGrid(loggedUser);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

            DisplayNewLabel(label6, new int[2] { 230, 160 }, new int[2] { 168, 24 }, loggedUser + " - address");
            DisplayNewDataGridView(dataGridView2, new int[2] { 230, 200 }, new int[2] { 650, 45 });
            dataGridView2.DataSource = BindCrtUserAddressToGrid(loggedUser);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.Refresh();
            
            DisplayNewLabel(label7, new int[2] { 950, 90 }, new int[2] { 168, 24 }, "Value");

            DisplayNewTextBox(textBox1, new int[2] { 950, 115 }, new int[2] { 60, 24 }, "Value");
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);

            DisplayNewButton(button15, new int[2] { 1030, 115 }, new int[2] { 60, 23 }, "button15", "Update");
            button15.Click += new EventHandler(button15_Click);


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[0].Cells[e.ColumnIndex].Value != null && e.ColumnIndex>=1 )
            {
                string cellContent = dataGridView1.Rows[0].Cells[e.ColumnIndex].Value.ToString();
                textBox1.Text = cellContent;
                textBox1.Refresh();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            HideUserInformationFormElements();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string value = textBox1.Text;
            int activeCellIndex = dataGridView1.CurrentCell.ColumnIndex;
            string activeColumn = dataGridView1.Columns[activeCellIndex].Name;
            //MessageBox.Show("cell column index:"+activeCellIndex);
           
            MessageBox.Show("updating " + activeColumn+" with "+ value);
            DBUpdates.WriteUserPersonalDataToDB(activeColumn, value);
            dataGridView1.Refresh();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void ShoWUserInformationFormElements()
        {
            label5.Show();
            dataGridView1.Show();
            textBox1.Show();
            label6.Show();
            dataGridView2.Show();
            label7.Show();
            button15.Show();
        }
        private void HideUserInformationFormElements()
        {
            dataGridView1.Hide();
            dataGridView2.Hide();
            textBox1.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            button15.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
