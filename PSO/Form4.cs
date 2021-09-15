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

        private void button4_Click(object sender, EventArgs e)
        {
            Label label15 = new Label();
            string loggedUser = ActiveForm.Text;
            //DisplayNewLabel(label15, new int[2] { 230, 50 }, new int[2] { 168, 24 }, "User info");
            DisplayNewLabel(label15, new int[2] { 230, 50 }, new int[2] { 168, 24 }, loggedUser + " - personal info");
            DisplayNewDataGridView(dataGridView1, new int[2] { 230, 90 }, new int[2] { 650, 45 });
            dataGridView1.DataSource = BindCrtUserDataToGrid(loggedUser);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();

            Label label16 = new Label();
            DisplayNewLabel(label16, new int[2] { 230, 160 }, new int[2] { 168, 24 }, loggedUser + " - address");
            DisplayNewDataGridView(dataGridView2, new int[2] { 230, 200 }, new int[2] { 650, 45 });
            dataGridView2.DataSource = BindCrtUserAddressToGrid(loggedUser);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.Refresh();


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("cell clicked");
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }
    
    }
}
