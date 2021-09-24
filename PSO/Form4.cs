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
        Label label10 = new Label();
        Label label11 = new Label();
        Label label12 = new Label();
        Label label13 = new Label();
        Label label14 = new Label();
        Label label15 = new Label();
        Label label16 = new Label();
        Label label17 = new Label();
        Label label18 = new Label();
        Label label19 = new Label();
        Label label20 = new Label();
        Label label21 = new Label();
        Label label22 = new Label();
        Label label23 = new Label();

        Button button21 = new Button();
        Button button22 = new Button();
        Button button23 = new Button();
        Button button24 = new Button();
        Button button25 = new Button();
        TextBox textBox5 = new TextBox();
        TextBox textBox6 = new TextBox();
        TextBox textBox7 = new TextBox();
        TextBox textBox8 = new TextBox();
        TextBox textBox9 = new TextBox();
        TextBox textBox10 = new TextBox();
        TextBox textBox11 = new TextBox();
        TextBox textBox12 = new TextBox();
        ListBox listBox1 = new ListBox();
        ListBox listBox2 = new ListBox();
        ListBox listBox3 = new ListBox();

        private void button4_Click(object sender, EventArgs e)
        {
            panel5.Hide();
            panel6.Hide();
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
            DisplayNewLabelOnPanel(label5, panel7, new int[2] { origX+ xMargin, yPosLabel5 }, new int[2] 
                { 168, 24 }, "Personal info");

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
            DisplayNewLabelOnPanel(label6, panel7, new int[2] { origX + xMargin, yPosLabel6 }, new int[2] 
                { sizeXLabel6, sizeYLabel6 }, "Address");

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
            DisplayNewLabelOnPanel(label7, panel7, new int[2] { xPosLabel7, yPosLabel7 }, new int[2] 
                { sizeXLabel7, sizeYLabel7 }, "Value");

            int xPosTextBox1 = xPosLabel7;
            int yPosTextBox1 = yPosLabel7+ sizeYLabel7 + 3;
            int sizeXTextBox1 = 60;
            int sizeYTextBox1 = 24;
            DisplayNewTextBoxOnPanel(textBox1, panel7, new int[2] { xPosTextBox1, yPosTextBox1 }, new int[2] 
                { sizeXTextBox1, sizeYTextBox1 }, "Value");
            textBox1.TextChanged += new EventHandler(textBox1_TextChanged);

            int xPosButton15 = xPosTextBox1 + sizeXTextBox1 + 10;
            int yPosButton15 = yPosTextBox1;
            int sizeXButton15 = 60;
            int sizeYButton15 = 24;
            DisplayNewButtonOnPanel(button15, panel7, new int[2] { xPosButton15, yPosButton15 }, new int[2] 
                { sizeXButton15, sizeYButton15 }, "button15", "Update");
            button15.Click += new EventHandler(button15_Click);

            int xPosLabel8 = xPosDataGridView2 + sizeXDataGridView2 + xItemsSpace;
            int yPosLabel8 = yPosDataGridView2;
            int sizeXLabel8 = 168;
            int sizeYLabel8 = 24;
            DisplayNewLabelOnPanel(label8, panel7, new int[2] { xPosLabel8, yPosLabel8 }, new int[2] 
                { sizeXLabel8, sizeYLabel8 }, "Value");

            int xPosTextBox2 = xPosLabel8;
            int yPosTextBox2 = yPosLabel8 + sizeYLabel8 + 3;
            int sizeXTextBox2 = 60;
            int sizeYTextBox2 = 24;
            DisplayNewTextBoxOnPanel(textBox2, panel7, new int[2] { xPosTextBox2, yPosTextBox2 }, new int[2]
                { sizeXTextBox2, sizeYTextBox2 }, "Value");
            textBox2.TextChanged += new EventHandler(textBox2_TextChanged);

            int xPosButton16 = xPosTextBox2 + sizeXTextBox2 + 10;
            int yPosButton16 = yPosTextBox2;
            int sizeXButton16 = 60;
            int sizeYButton16 = 24;
            DisplayNewButtonOnPanel(button16, panel7, new int[2] { xPosButton16, yPosButton16 }, new int[2] 
                { sizeXButton16, sizeYButton16 }, "button16", "Update");
            button16.Click += new EventHandler(button16_Click);

            int xPosLabel9 = xPosDataGridView2;
            int yPosLabel9 = yPosDataGridView2 + sizeYDataGridView2 + yItemsSpace;
            int sizeXLabel9 = 168;
            int sizeYLabel9 = 24;
            DisplayNewLabelOnPanel(label9, panel7, new int[2] { xPosLabel9, yPosLabel9 }, new int[2] 
                { sizeXLabel9, sizeYLabel9 }, "Password");

            int xPosButton17 = xPosLabel9;
            int yPosButton17 = yPosLabel9 + sizeYLabel9 + yItemsSpace;
            int sizeXButton17 = 120;
            int sizeYButton17 = 24;
            DisplayNewButtonOnPanel(button17, panel7, new int[2] { xPosButton17, yPosButton17 }, new int[2] 
                { sizeXButton17, sizeYButton17 }, "button17", "Change Password");
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
            DisplayNewTextBoxOnPanel(textBox3, panel7, new int[2] { xPosTextBox3, yPosTextBox3 }, new int[2]
                { sizeXTextBox3, sizeYTextBox3 }, "old password");
            textBox3.TextChanged += new EventHandler(textBox3_TextChanged);

            int xPosTextBox4 = xPosTextBox3;
            int yPosTextBox4 = label9.Location.Y + 40;
            int sizeXTextBox4 = 120;
            int sizeYTextBox4 = 24;
            DisplayNewTextBoxOnPanel(textBox4, panel7, new int[2] { xPosTextBox4, yPosTextBox4 }, new int[2]
                { sizeXTextBox4, sizeYTextBox4 }, "new password");
            textBox4.TextChanged += new EventHandler(textBox4_TextChanged);

            int xPosButton18 = xPosTextBox3 + sizeXTextBox3 + 10;
            int yPosButton18 = yPosTextBox3;
            int sizeXButton18 = 60;
            int sizeYButton18 = 24;
            DisplayNewButtonOnPanel(button18, panel7, new int[2] { xPosButton18, yPosButton18 }, new int[2] 
                { sizeXButton18, sizeYButton18 }, "button18", "Update Password");
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
            int[] panelItemsOriginCoord = new int[2] { 20, 20 };
            int origX = panelItemsOriginCoord[0];
            int origY = panelItemsOriginCoord[1];
            int xMargin = 5;
            int yMargin = 5;
            int xItemsSpace = 40;
            int yItemsSpace = 5;

            panel7.Hide();
            panel5.Show();
            panel6.Show();
            DisplayNewPanel(panel5, new int[2] { 300, 82 }, new int[2] { 180, 350 }, "panel5", true);
            DisplayNewPanel(panel6, new int[2] { 550, 82 }, new int[2] { 500, 350 }, "panel6", true);

            int xPosButton19 = origX;
            int yPosButton19 = origY;
            int sizeXButton19 = 140;
            int sizeYButton19 = 24;
            DisplayNewButtonOnPanel(button19, panel5, new int[2] { origX, origY }, new int[2] { sizeXButton19, sizeYButton19 },
                "button19", "Add main characteristics");
            button19.Click += new EventHandler(button19_Click);

            int xPosButton20 = xPosButton19;
            int yPosButton20 = yPosButton19 + sizeYButton19 + yItemsSpace;
            int sizeXButton20 = 140;
            int sizeYButton20 = 24;
            DisplayNewButtonOnPanel(button20, panel5, new int[2] { xPosButton20, yPosButton20 }, new int[2] 
                { sizeXButton20, sizeYButton20 }, "button20", "Add sec characteristics");
            button20.Click += new EventHandler(button20_Click);

            int xPosButton21 = xPosButton19;
            int yPosButton21 = yPosButton20 + sizeYButton20 + yItemsSpace;
            int sizeXButton21 = 140;
            int sizeYButton21 = 24;
            DisplayNewButtonOnPanel(button21, panel5, new int[2] { xPosButton21, yPosButton21 }, new int[2]
                { sizeXButton21, sizeYButton21 }, "button21", "Add Product");
            button21.Click += new EventHandler(button21_Click);


        }
        private void button19_Click(object sender, EventArgs e)
        {
            int[] panelItemsOriginCoord = new int[2] { 20, 20 };
            int origX = panelItemsOriginCoord[0];
            int origY = panelItemsOriginCoord[1];
            int xMargin = 5;
            int yMargin = 5;
            int xItemsSpace = 40;
            int yItemsSpace = 15;

            panel7.Hide();
            panel6.Show();
            clearPanel(panel6);

            string label10Text = "Please add product main characteristics";
            int xPosLabel10 = 3*xMargin;
            int yPosLabel10 = yMargin;
            int sizeXLabel10 = ClaculateLabelLenght(label10Text);
            int sizeYLabel10 = 24;
            DisplayNewLabelOnPanel(label10, panel6, new int[2] { xPosLabel10, yPosLabel10 }, new int[2] 
                { sizeXLabel10, sizeYLabel10 }, label10Text);

            string label11Text = "Category";
            int xPosLabel11 = 3*xMargin;
            int yPosLabel11 = yPosLabel10 + sizeYLabel10 + 2 * yItemsSpace;
            int sizeXLabel11 = ClaculateLabelLenght(label11Text);
            int sizeYLabel11 = 24;
            DisplayNewLabelOnPanel(label11, panel6, new int[2] { xPosLabel11, yPosLabel11 }, new int[2]
                { sizeXLabel11, sizeYLabel11 }, label11Text);

            int xPosTextBox5 = xPosLabel11;
            int yPosTextBox5 = yPosLabel11 + sizeYLabel11 + yItemsSpace;
            int sizeXTextBox5 = 120;
            int sizeYTextBox5 = 24;
            DisplayNewTextBoxOnPanel(textBox5, panel6, new int[2] { xPosTextBox5, yPosTextBox5 }, new int[2]
                { sizeXTextBox5, sizeYTextBox5 }, "new category");
            textBox5.TextChanged += new EventHandler(textBox5_TextChanged);

            int xPosButton22 = xPosTextBox5;
            int yPosButton22 = yPosTextBox5 + sizeYTextBox5 + yItemsSpace;
            int sizeXButton22 = 40;
            int sizeYButton22 = 24;
            DisplayNewButtonOnPanel(button22, panel6, new int[2] { xPosButton22, yPosButton22 }, new int[2]
                { sizeXButton22, sizeYButton22 }, "button22", "Add");
            button22.Click += new EventHandler(button22_Click);





            string label12Text = "Manufacturer";
            int xPosLabel12 = xPosLabel11 + sizeXLabel11 + xItemsSpace*4;
            int yPosLabel12 = yPosLabel11;
            int sizeXLabel12 = ClaculateLabelLenght(label12Text);
            int sizeYLabel12 = 24;
            DisplayNewLabelOnPanel(label12, panel6, new int[2] { xPosLabel12, yPosLabel12 }, new int[2]
                { sizeXLabel12, sizeYLabel12 }, label12Text);

            int xPosTextBox6 = xPosLabel12;
            int yPosTextBox6 = yPosLabel12 + sizeYLabel12 + yItemsSpace;
            int sizeXTextBox6 = 120;
            int sizeYTextBox6 = 24;
            DisplayNewTextBoxOnPanel(textBox6, panel6, new int[2] { xPosTextBox6, yPosTextBox6 }, new int[2]
                { sizeXTextBox6, sizeYTextBox6 }, "new manufacturer");
            textBox6.TextChanged += new EventHandler(textBox6_TextChanged);

            int xPosButton23 = xPosTextBox6;
            int yPosButton23 = yPosTextBox6 + sizeYTextBox6 + yItemsSpace;
            int sizeXButton23 = 40;
            int sizeYButton23 = 24;
            DisplayNewButtonOnPanel(button23, panel6, new int[2] { xPosButton23, yPosButton23 }, new int[2]
                { sizeXButton23, sizeYButton23 }, "button23", "Add");
            button23.Click += new EventHandler(button23_Click);


        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void button20_Click(object sender, EventArgs e)
        {
            int[] panelItemsOriginCoord = new int[2] { 20, 20 };
            int origX = panelItemsOriginCoord[0];
            int origY = panelItemsOriginCoord[1];
            int xMargin = 5;
            int yMargin = 5;
            int xItemsSpace = 40;
            int yItemsSpace = 15;

            panel7.Hide();
            panel6.Show();
            clearPanel(panel6);

            string label14Text = "Please add product secondary characteristics";
            int xPosLabel14 = 3*xMargin;
            int yPosLabel14 = yMargin;
            int sizeXLabel14 = ClaculateLabelLenght(label14Text);
            int sizeYLabel14 = 24;
            DisplayNewLabelOnPanel(label14, panel6, new int[2] { xPosLabel14, yPosLabel14 }, new int[2]
                { sizeXLabel14, sizeYLabel14 }, label14Text);

            string label13Text = "Subcategory";
            int xPosLabel13 = xPosLabel14;
            int yPosLabel13 = yPosLabel14 + sizeYLabel14 + 2 * yItemsSpace;
            int sizeXLabel13 = ClaculateLabelLenght(label13Text);
            int sizeYLabel13 = 24;
            DisplayNewLabelOnPanel(label13, panel6, new int[2] { xPosLabel13, yPosLabel13 }, new int[2]
                { sizeXLabel13, sizeYLabel13 }, label13Text);

            string label15Text = "Category";
            int xPosLabel15 = xPosLabel13 + sizeXLabel13 + 2 * xItemsSpace;
            int yPosLabel15 = yPosLabel13;
            int sizeXLabel15 = ClaculateLabelLenght(label13Text);
            int sizeYLabel15 = 24;
            DisplayNewLabelOnPanel(label15, panel6, new int[2] { xPosLabel15, yPosLabel15 }, new int[2]
                { sizeXLabel15, sizeYLabel15 }, label15Text);

            int xPosTextBox7 = xPosLabel13;
            int yPosTextBox7 = yPosLabel13 + sizeYLabel13 + yItemsSpace;
            int sizeXTextBox7 = 120;
            int sizeYTextBox7 = 24;
            DisplayNewTextBoxOnPanel(textBox7, panel6, new int[2] { xPosTextBox7, yPosTextBox7 }, new int[2]
                { sizeXTextBox7, sizeYTextBox7 }, "new subcategory");
            textBox7.TextChanged += new EventHandler(textBox7_TextChanged);

            string listBox1Text = "Select Category";
            int xlistBox1 = xPosLabel15;
            int ylistBox1 = yPosTextBox7;
            int sizeXlistBox1 = 140;
            int sizeYlistBox1 = 90; 
            DisplayListBox(listBox1, panel6, new int[2] { xlistBox1, ylistBox1 }, new int[2]
                { sizeXlistBox1, sizeYlistBox1 }, listBox1Text, BindCategories());
            listBox1.DataSource = BindCategories();
            listBox1.SelectedIndexChanged += new EventHandler(listBox1_SelectedIndexChanged);
            

            int xPosButton24 = xPosTextBox7;
            int yPosButton24 = yPosTextBox7 + sizeYTextBox7 + yItemsSpace;
            int sizeXButton24 = 40;
            int sizeYButton24 = 24;
            DisplayNewButtonOnPanel(button24, panel6, new int[2] { xPosButton24, yPosButton24 }, new int[2]
                { sizeXButton24, sizeYButton24 }, "button24", "Add");
            button24.Click += new EventHandler(button24_Click);



        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            int[] panelItemsOriginCoord = new int[2] { 20, 20 };
            int origX = panelItemsOriginCoord[0];
            int origY = panelItemsOriginCoord[1];
            int xMargin = 5;
            int yMargin = 5;
            int xItemsSpace = 40;
            int yItemsSpace = 15;

            panel7.Hide();
            panel6.Show();
            clearPanel(panel6);

            string label16Text = "Please fill all product fields";
            int xPosLabel16 = 3*xMargin;
            int yPosLabel16 = yMargin;
            int sizeXLabel16 = ClaculateLabelLenght(label16Text);
            int sizeYLabel16 = 24;
            DisplayNewLabelOnPanel(label16, panel6, new int[2] { xPosLabel16, yPosLabel16 }, new int[2]
                { sizeXLabel16, sizeYLabel16 }, label16Text);

            string label17Text = "Product name:";
            int xPosLabel17 = xPosLabel16;
            int yPosLabel17 = yPosLabel16 + sizeYLabel16 + 2*yItemsSpace;
            int sizeXLabel17 = ClaculateLabelLenght(label17Text);
            int sizeYLabel17 = 24;
            DisplayNewLabelOnPanel(label17, panel6, new int[2] { xPosLabel17, yPosLabel17 }, new int[2]
                { sizeXLabel17, sizeYLabel17 }, label17Text);

            string label18Text = "Product model:";
            int xPosLabel18 = xPosLabel17 + sizeXLabel17 + 4*xItemsSpace;
            int yPosLabel18 = yPosLabel17;
            int sizeXLabel18 = ClaculateLabelLenght(label17Text);
            int sizeYLabel18 = 24;
            DisplayNewLabelOnPanel(label18, panel6, new int[2] { xPosLabel18, yPosLabel18 }, new int[2]
                { sizeXLabel18, sizeYLabel18 }, label18Text);

            int xPosTextBox8 = xPosLabel17;
            int yPosTextBox8 = yPosLabel17 + sizeYLabel17 + yItemsSpace;
            int sizeXTextBox8 = 130;
            int sizeYTextBox8 = 24;
            DisplayNewTextBoxOnPanel(textBox8, panel6, new int[2] { xPosTextBox8, yPosTextBox8 }, new int[2]
                { sizeXTextBox8, sizeYTextBox8 }, "Product name");
            //textBox8.TextChanged += new EventHandler(textBox8_TextChanged);

            int xPosTextBox9 = xPosLabel18;
            int yPosTextBox9 = yPosLabel18 + sizeYLabel18 + yItemsSpace;
            int sizeXTextBox9 = 130;
            int sizeYTextBox9 = 24;
            DisplayNewTextBoxOnPanel(textBox9, panel6, new int[2] { xPosTextBox9, yPosTextBox9 }, new int[2]
                { sizeXTextBox9, sizeYTextBox9 }, "Product model");
            //textBox9.TextChanged += new EventHandler(textBox9_TextChanged);

            string label19Text = "Manufacturer:";
            int xPosLabel19 = xPosLabel17;
            int yPosLabel19 = yPosTextBox8 + sizeYTextBox8 + yItemsSpace;
            int sizeXLabel19 = ClaculateLabelLenght(label19Text);
            int sizeYLabel19 = 24;
            DisplayNewLabelOnPanel(label19, panel6, new int[2] { xPosLabel19, yPosLabel19 }, new int[2]
                { sizeXLabel19, sizeYLabel19 }, label19Text);

            string label20Text = "Subcategory:";
            int xPosLabel20 = xPosLabel18;
            int yPosLabel20 = yPosTextBox9 + sizeYTextBox9 + yItemsSpace;
            int sizeXLabel20 = ClaculateLabelLenght(label20Text);
            int sizeYLabel20 = 24;
            DisplayNewLabelOnPanel(label20, panel6, new int[2] { xPosLabel20, yPosLabel20 }, new int[2]
                { sizeXLabel20, sizeYLabel20 }, label20Text);

            
            string listBox2Text = "Select Manufacturer";
            int xlistBox2 = xPosLabel19;
            int ylistBox2 = yPosLabel19 + sizeYLabel19 + yItemsSpace;
            int sizeXlistBox2 = 140;
            int sizeYlistBox2 = 70;
            DisplayListBox(listBox2, panel6, new int[2] { xlistBox2, ylistBox2 }, new int[2]
                { sizeXlistBox2, sizeYlistBox2 }, listBox2Text, BindManufacturers());
            //listBox2.DataSource = BindManufacturers();  
            listBox2.SelectedIndexChanged += new EventHandler(listBox2_SelectedIndexChanged);

            string listBox3Text = "Select subcategory";
            int xlistBox3 = xPosLabel20;
            int ylistBox3 = yPosLabel20 + sizeYLabel20 + yItemsSpace;
            int sizeXlistBox3 = 140;
            int sizeYlistBox3 = 70;
            DisplayListBox(listBox3, panel6, new int[2] { xlistBox3, ylistBox3 }, new int[2]
                { sizeXlistBox3, sizeYlistBox3 }, listBox3Text, BindSubcategories());
            //listBox2.DataSource = BindManufacturers();
            listBox2.SelectedIndexChanged += new EventHandler(listBox2_SelectedIndexChanged);

            string label21Text = "Starting stock:";
            int xPosLabel21 = xPosLabel19;
            int yPosLabel21 = ylistBox2 + sizeYlistBox2 + yItemsSpace;
            int sizeXLabel21 = ClaculateLabelLenght(label21Text);
            int sizeYLabel21 = 24;
            DisplayNewLabelOnPanel(label21, panel6, new int[2] { xPosLabel21, yPosLabel21 }, new int[2]
                { sizeXLabel21, sizeYLabel21 }, label21Text);

            string label22Text = "Sell price:";
            int xPosLabel22 = xPosLabel21 + sizeXLabel21 + 2*xItemsSpace;
            int yPosLabel22 = yPosLabel21;
            int sizeXLabel22 = ClaculateLabelLenght(label22Text);
            int sizeYLabel22 = 24;
            DisplayNewLabelOnPanel(label22, panel6, new int[2] { xPosLabel22, yPosLabel22 }, new int[2]
                { sizeXLabel22, sizeYLabel22 }, label22Text);

            string label23Text = "Supplier price:";
            int xPosLabel23 = xPosLabel22 + sizeXLabel22 + 2 * xItemsSpace;
            int yPosLabel23 = yPosLabel21;
            int sizeXLabel23 = ClaculateLabelLenght(label22Text);
            int sizeYLabel23 = 24;
            DisplayNewLabelOnPanel(label23, panel6, new int[2] { xPosLabel23, yPosLabel23 }, new int[2]
                { sizeXLabel23, sizeYLabel23 }, label23Text);

            int xPosTextBox10 = xPosLabel21;
            int yPosTextBox10 = yPosLabel21 + sizeYLabel21 + yItemsSpace;
            int sizeXTextBox10 = 70;
            int sizeYTextBox10 = 24;
            DisplayNewTextBoxOnPanel(textBox10, panel6, new int[2] { xPosTextBox10, yPosTextBox10 }, new int[2]
                { sizeXTextBox10, sizeYTextBox10 }, "Stock");
            //textBox10.TextChanged += new EventHandler(textBox10_TextChanged);

            int xPosTextBox11 = xPosLabel22;
            int yPosTextBox11 = yPosLabel22 + sizeYLabel22 + yItemsSpace;
            int sizeXTextBox11 = 70;
            int sizeYTextBox11 = 24;
            DisplayNewTextBoxOnPanel(textBox11, panel6, new int[2] { xPosTextBox11, yPosTextBox11 }, new int[2]
                { sizeXTextBox11, sizeYTextBox11 }, "sell price");
            //textBox11.TextChanged += new EventHandler(textBox11_TextChanged);

            int xPosTextBox12 = xPosLabel23;
            int yPosTextBox12 = yPosLabel23 + sizeYLabel22 + yItemsSpace;
            int sizeXTextBox12 = 70;
            int sizeYTextBox12 = 24;
            DisplayNewTextBoxOnPanel(textBox12, panel6, new int[2] { xPosTextBox12, yPosTextBox12 }, new int[2]
                { sizeXTextBox12, sizeYTextBox12 }, "Supplier price");

            string Button25Text = "Add product to DB";
            int xPosButton25 = xPosLabel16 + sizeXLabel16 + 3*xItemsSpace;
            int yPosButton25 = yPosLabel16;
            int sizeXButton25 = ClaculateLabelLenght(Button25Text)*2;
            int sizeYButton25 = 24;
            DisplayNewButtonOnPanel(button25, panel6, new int[2] { xPosButton25, yPosButton25 }, new int[2]
                { sizeXButton25, sizeYButton25 }, "button25", Button25Text);
            button25.Click += new EventHandler(button25_Click);
            


        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            string newCategory = textBox5.Text;
            if((newCategory!= string.Empty) && (newCategory != "new category") )
            {
                DBUpdates.CreateNewCategory(newCategory);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            string newManufacturer = textBox6.Text;
            if ((newManufacturer != string.Empty) && (newManufacturer != "new manufacturer"))
            {
                DBUpdates.CreateNewManufacturer(newManufacturer);
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            string subCategory = textBox7.Text;
            string category = listBox1.SelectedItem.ToString();
            if ((subCategory != string.Empty) && (subCategory != "new subcategory"))
            {
                DBUpdates.CreateNewSubCategory(subCategory, category);
            }
        }
        private void button25_Click(object sender, EventArgs e)
        {
            

            if (CheckNewProductDataInputCorrectness())
            {
                string[] productProperties = new string[4]
                                { textBox8.Text, textBox9.Text,
                                  listBox2.SelectedItem.ToString(),
                                  listBox3.SelectedItem.ToString()};
                int startingStock = int.Parse(textBox10.Text);
                decimal sellPrice = decimal.Parse(textBox11.Text);
                decimal supplierPrice = decimal.Parse(textBox12.Text);
                decimal[] prices = new decimal[2] { sellPrice, supplierPrice };

                DBUpdates.CreateNewProduct(productProperties, startingStock, prices);

            }
        }

        private bool CheckNewProductDataInputCorrectness()
        {
            bool correctInputData = false;
            int startingStock;
            decimal sellPrice;
            decimal supplierPrice;
            if(   textBox8.Text != String.Empty
               && textBox9.Text != String.Empty
               && textBox10.Text != String.Empty
               && textBox11.Text != String.Empty
               && textBox12.Text != String.Empty
               && textBox8.Text != "Product name"
               && textBox9.Text != "Product model"
               && int.TryParse(textBox10.Text, out startingStock)
               && decimal.TryParse(textBox11.Text, out sellPrice)
               && decimal.TryParse(textBox12.Text, out supplierPrice) )
            {
                correctInputData = true;
            }

            return correctInputData;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
