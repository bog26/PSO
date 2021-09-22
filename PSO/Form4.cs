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
        Label label8 = new Label();
        TextBox textBox2 = new TextBox();
        Button button16 = new Button();
        Label label9 = new Label();
        Button button17 = new Button();
        TextBox textBox3 = new TextBox(); //old pass
        TextBox textBox4 = new TextBox(); //new pass
        Button button18 = new Button();
        Panel panel5 = new Panel();
        Button button19 = new Button();
        Panel panel6 = new Panel();
        Button button20 = new Button();
        Panel panel7 = new Panel();

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            panel7.Show();
            DisplayNewPanel(panel7, new int[2] { 235, 46 }, new int[2] { 900, 350 }, "panel7", true);
            int[] panelItemsOriginCoord = new int[2] {5, 5};
            int origX = panelItemsOriginCoord[0];
            int origY = panelItemsOriginCoord[1];
            int xMargin = 5;
            int yMargin = 5;
            int xItemsSpace = 40;
            int yItemsSpace = 15;

            int yPosLabel5 = origY + yMargin;
            DisplayNewLabelOnPanel(label5, panel7, new int[2] { origX+ xMargin, yPosLabel5 }, new int[2] { 168, 24 }, "Personal info");

            string loggedUser = ActiveForm.Text;
            int xPosDataGridView1 = origX + xMargin;
            int yPosDataGridView1 = yPosLabel5 + yItemsSpace + 24;
            int sizeXDataGridView1 = 650;
            int sizeYDataGridView1 = 45;
            DisplayNewDataGridViewOnPanel(dataGridView1, panel7, new int[2]
                { xPosDataGridView1, yPosDataGridView1}, new int[2] { sizeXDataGridView1, sizeYDataGridView1 });
            dataGridView1.DataSource = BindCrtUserDataToGrid(loggedUser);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellContentClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

            int yPosLabel6 = yPosDataGridView1 + yItemsSpace + sizeYDataGridView1;
            int sizeXLabel6 = 168;
            int sizeYLabel6 = 24;
            DisplayNewLabelOnPanel(label6, panel7, new int[2] { origX + xMargin, yPosLabel6 }, new int[2] { sizeXLabel6, sizeYLabel6 }, "Address");

            int xPosDataGridView2 = xPosDataGridView1;
            int yPosDataGridView2 = yPosLabel6 + yItemsSpace + sizeYLabel6;
            int sizeXDataGridView2 = 650;
            int sizeYDataGridView2 = 45;
            DisplayNewDataGridViewOnPanel(dataGridView2, panel7, new int[2]
                { origX + xMargin, yPosDataGridView2}, new int[2] { sizeXDataGridView2, sizeYDataGridView2 });
            dataGridView2.DataSource = BindCrtUserAddressToGrid(loggedUser);
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.CellContentClick += new DataGridViewCellEventHandler(dataGridView2_CellContentClick);

            int xPosLabel7 = xPosDataGridView1 + sizeXDataGridView1 + xItemsSpace;
            int yPosLabel7 = yPosDataGridView1;
            int sizeXLabel7 = 168;
            int sizeYLabel7 = 24;
            DisplayNewLabelOnPanel(label7, panel7, new int[2] { xPosLabel7, yPosLabel7 }, new int[2] { sizeXLabel7, sizeYLabel7 }, "Value");

            int xPosTextBox1 = xPosLabel7;
            int yPosTextBox1 = yPosLabel7+ sizeYLabel7 + 3;
            int sizeXTextBox1 = 60;
            int sizeYTextBox1 = 24;
            DisplayNewTextBoxOnPanel(textBox1, panel7, new int[2] { xPosTextBox1, yPosTextBox1 }, new int[2] { sizeXTextBox1, sizeYTextBox1 }, "Value");
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);

            int xPosButton15 = xPosTextBox1 + sizeXTextBox1 + 10;
            int yPosButton15 = yPosTextBox1;
            int sizeXButton15 = 60;
            int sizeYButton15 = 24;
            DisplayNewButtonOnPanel(button15, panel7, new int[2] { xPosButton15, yPosButton15 }, new int[2] { sizeXButton15, sizeYButton15 }, "button15", "Update");
            button15.Click += new EventHandler(button15_Click);

            int xPosLabel8 = xPosDataGridView2 + sizeXDataGridView2 + xItemsSpace;
            int yPosLabel8 = yPosDataGridView2;
            int sizeXLabel8 = 168;
            int sizeYLabel8 = 24;
            DisplayNewLabelOnPanel(label8, panel7, new int[2] { xPosLabel8, yPosLabel8 }, new int[2] { sizeXLabel8, sizeYLabel8 }, "Value");

            int xPosTextBox2 = xPosLabel8;
            int yPosTextBox2 = yPosLabel8 + sizeYLabel8 + 3;
            int sizeXTextBox2 = 60;
            int sizeYTextBox2 = 24;
            DisplayNewTextBoxOnPanel(textBox2, panel7, new int[2] { xPosTextBox2, yPosTextBox2 }, new int[2] { sizeXTextBox2, sizeYTextBox2 }, "Value");
            textBox2.TextChanged += new EventHandler(textBox2_TextChanged);

            int xPosButton16 = xPosTextBox2 + sizeXTextBox2 + 10;
            int yPosButton16 = yPosTextBox2;
            int sizeXButton16 = 60;
            int sizeYButton16 = 24;
            DisplayNewButtonOnPanel(button16, panel7, new int[2] { xPosButton16, yPosButton16 }, new int[2] { sizeXButton16, sizeYButton16 }, "button16", "Update");
            button16.Click += new EventHandler(button16_Click);

            int xPosLabel9 = xPosDataGridView2;
            int yPosLabel9 = yPosDataGridView2 + sizeYDataGridView2 + yItemsSpace;
            int sizeXLabel9 = 168;
            int sizeYLabel9 = 24;
            DisplayNewLabelOnPanel(label9, panel7, new int[2] { xPosLabel9, yPosLabel9 }, new int[2] { sizeXLabel9, sizeYLabel9 }, "Password");

            int xPosButton17 = xPosLabel9;
            int yPosButton17 = yPosLabel9 + sizeYLabel9 + yItemsSpace;
            int sizeXButton17 = 120;
            int sizeYButton17 = 24;
            DisplayNewButtonOnPanel(button17, panel7, new int[2] { xPosButton17, yPosButton17 }, new int[2] { sizeXButton17, sizeYButton17 }, "button17", "Change Password");
            button17.Click += new EventHandler(button17_Click);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[0].Cells[e.ColumnIndex].Value != null)
            {
                string cellContent = dataGridView2.Rows[0].Cells[e.ColumnIndex].Value.ToString();
                textBox2.Text = cellContent;
                textBox2.Refresh();
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
           
            //MessageBox.Show("updating " + activeColumn+" with "+ value);
            UpdateDataGridMessageBox(activeColumn, value);
            DBUpdates.WriteUserPersonalDataToDB(activeColumn, value);
            dataGridView1.Refresh();
        }

        private void button16_Click(object sender, EventArgs e) 
        {
            string value = textBox2.Text;
            int activeCellIndex = dataGridView2.CurrentCell.ColumnIndex;
            string activeColumn = dataGridView2.Columns[activeCellIndex].Name;

            //MessageBox.Show("updating " + activeColumn + " with " + value);
            UpdateDataGridMessageBox(activeColumn, value);

            DBUpdates.WriteUserAddressToDB(activeColumn, value);
            dataGridView2.Refresh();
        }

        private void UpdateDataGridMessageBox(string column, string value)
        {
            MessageBox.Show("updating " + column + " with " + value);
        }


        private void button17_Click(object sender, EventArgs e)
        {

            int xPosTextBox3 = label9.Location.X + label9.Size.Width + 45;
            int yPosTextBox3 = label9.Location.Y;
            int sizeXTextBox3 = 120;
            int sizeYTextBox3 = 24;
            DisplayNewTextBoxOnPanel(textBox3, panel7, new int[2] { xPosTextBox3, yPosTextBox3 }, new int[2] { sizeXTextBox3, sizeYTextBox3 }, "old password");
            textBox3.TextChanged += new EventHandler(textBox3_TextChanged);

            int xPosTextBox4 = xPosTextBox3;
            int yPosTextBox4 = label9.Location.Y + 40;
            int sizeXTextBox4 = 120;
            int sizeYTextBox4 = 24;
            DisplayNewTextBoxOnPanel(textBox4, panel7, new int[2] { xPosTextBox4, yPosTextBox4 }, new int[2] { sizeXTextBox4, sizeYTextBox4 }, "new password");
            textBox4.TextChanged += new EventHandler(textBox4_TextChanged);

            int xPosButton18 = xPosTextBox3 + sizeXTextBox3 + 10;
            int yPosButton18 = yPosTextBox3;
            int sizeXButton18 = 60;
            int sizeYButton18 = 24;
            DisplayNewButtonOnPanel(button18, panel7, new int[2] { xPosButton18, yPosButton18 }, new int[2] { sizeXButton18, sizeYButton18 }, "button18", "Update Password");
            button18.Click += new EventHandler(button18_Click);

        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    
        private void HideUserInformationFormElements()
        {
            clearPanel(panel7);
        }
        private void button13_Click(object sender, EventArgs e)
        {

        }
        private void button18_Click(object sender, EventArgs e)
        {
            if(InternalDBQueries.CheckForCorrectPassword(Form.ActiveForm.Text, textBox3.Text))
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

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            panel5.Show();
            DisplayNewPanel(panel5, new int[2] { 300, 82 }, new int[2] { 183, 160 }, "panel5", true);

            DisplayNewButtonOnPanel(button19, panel5, new int[2] { 20, 20 }, new int[2] { 120, 24 }, "button19", "Add product manually");
            button19.Click += new EventHandler(button19_Click);
        }
        private void button19_Click(object sender, EventArgs e)
        {
            DisplayNewPanel(panel6, new int[2] { 550, 82 }, new int[2] { 500, 300 }, "panel6", true);
            DisplayNewButtonOnPanel(button20, panel6, new int[2] { 20, 20 }, new int[2] { 120, 24 }, "button20", "Clear left panel");
            button20.Click += new EventHandler(button20_Click);

        }
        private void button20_Click(object sender, EventArgs e)
        {
            clearPanel(panel5);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
