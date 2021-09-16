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
            Label label5 = new Label();
            string loggedUser = ActiveForm.Text;
            //DisplayNewLabel(label15, new int[2] { 230, 50 }, new int[2] { 168, 24 }, "User info");
            DisplayNewLabel(label5, new int[2] { 230, 50 }, new int[2] { 168, 24 }, loggedUser + " - personal info");
            DisplayNewDataGridView(dataGridView1, new int[2] { 230, 90 }, new int[2] { 650, 45 });
            dataGridView1.DataSource = BindCrtUserDataToGrid(loggedUser);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);


            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                for (int i = 1; i < dataGridView1.ColumnCount; i++)
                {
                    row.Cells[i].ReadOnly = false;
                    
                    
                }
            }


            //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter; //new
            //dataGridView1.EditMode = DataGridViewEditMode.EditProgrammatically;
            //dataGridView1.Refresh();

            Label label6 = new Label();
            DisplayNewLabel(label6, new int[2] { 230, 160 }, new int[2] { 168, 24 }, loggedUser + " - address");
            DisplayNewDataGridView(dataGridView2, new int[2] { 230, 200 }, new int[2] { 650, 45 });
            dataGridView2.DataSource = BindCrtUserAddressToGrid(loggedUser);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.Refresh();


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* //ok
            MessageBox.Show("cell clicked");
            Label label7 = new Label();
            DisplayNewLabel(label7, new int[2] { 950, 100 }, new int[2] { 168, 24 }, "cell click");
            */
            MessageBox.Show("cell clicked");

            /*
            //dataGridView1.BeginEdit(true); 
            //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            if(e.ColumnIndex>=1)
            //if (e!= null)
            {
                MessageBox.Show("cell clicked");
            }
            //MessageBox.Show("cell clicked");
            */
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
