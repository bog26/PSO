﻿using System;
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
            //ActiveForm.Text = "bol";  // change to external file
            InitializeManualAddedComponent();
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
            HideEmailPanels();
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
        
        //TBD: move all to Form4.Designer
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
        //Button button19 = new Button();
        //Panel panel6 = new Panel();
        //Button button20 = new Button();
        Panel panel7 = new Panel();
        //Button button21 = new Button();
        //Button button26 = new Button();



        private void button4_Click(object sender, EventArgs e)
        {
            //panel5.Hide();
            panel11.Hide();
            //panel6.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel15.Hide();
            HideEmailPanels();
            panel7.Show();
            DisplayNewPanel(panel7, new int[2] { 235, 46 }, new int[2] { 900, 350 }, "panel7", true);
            Form.ActiveForm.Controls.Add(panel7);
            int[] panelItemsOriginCoord = new int[2] {5, 5};
            int origX = panelItemsOriginCoord[0];
            int origY = panelItemsOriginCoord[1];
            int xMargin = 5;
            int yMargin = 5;
            int xItemsSpace = 40;
            int yItemsSpace = 15;

            //panel7.Show();

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

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnHeadIndex = -1;
            int[] allowedColumnIndexes = new int[4] {1,6,7,8};

            if (e.RowIndex != columnHeadIndex)
            {
                if (dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null
                    && DBUpdates.DataGridViewAllowCustomExtraction(e.ColumnIndex, allowedColumnIndexes))
                {
                    string cellContent = dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                    textBox16.Text = cellContent;
                    textBox16.Refresh();
                }
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            HideUserInformationFormElements();
            panel11.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel11.Hide();
            panel12.Hide();
            panel13.Hide();
            panel7.Hide();

            panel15.Show();
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
            HideEmailPanels();
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
            panel13.Hide();
            panel15.Hide();
            HideEmailPanels();
            panel11.Show();
        }
        private void button19_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            panel10.Hide();
            panel13.Hide();
            panel15.Hide();
            panel8.Show();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
        private void button20_Click(object sender, EventArgs e)
        {

            panel7.Hide();
            panel8.Hide();
            panel10.Hide();
            panel13.Hide();
            panel15.Hide();
            panel9.Show();

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {

            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel13.Hide();
            panel15.Hide();
            panel10.Show();
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel11.Hide();
            panel13.Hide();
            panel15.Hide();
            panel12.Show();

        }

        private void button27_Click(object sender, EventArgs e)
        {
            panel7.Hide();
            panel8.Hide();
            panel9.Hide();
            panel10.Hide();
            panel12.Hide();
            panel13.Hide();
            panel15.Hide();
            panel11.Show();

        }

        private void button28_Click(object sender, EventArgs e)
        {

            panel7.Hide();
            panel8.Hide();
            panel10.Hide();
            panel9.Hide();

            ProductsQuery();

        }
        private void button29_Click(object sender, EventArgs e)
        {
            if(button29.Text == "Disable edit")
            {
                button29.Text = "Enable edit";
                //panel14.Hide();
            }
            else
            {
                button29.Text = "Disable edit";
                //panel14.Hide();
            }
        }

        private void button30_Click(object sender, EventArgs e) 
        {
            if( AllowProductUpdate() )
            {
                string value = textBox16.Text;
                int activeCellIndex = dataGridView3.CurrentCell.ColumnIndex;
                int activeColumn = dataGridView3.Columns[activeCellIndex].DisplayIndex;
                int crtRowIndex = dataGridView3.CurrentCell.RowIndex;
                int crtProductId = int.Parse(dataGridView3.Rows[crtRowIndex].Cells[0].Value.ToString());
                bool successfulDBUpdate = DBUpdates.WriteProductDataToDB(crtProductId, activeColumn, value);
                if(successfulDBUpdate)
                {
                    ProductsQuery();
                    MessageBox.Show("DB updated");  
                }
                else 
                {
                    MessageBox.Show("DB update failed due to incorrect input data");
                }
            }
        }
        private bool AllowProductUpdate()
        {
            bool allowUpdate = false;
            if (checkBox3.Checked == true)
            {
                allowUpdate = true;
            }
            return allowUpdate;
        }

        private void ProductsQuery()
        {
            //dataGridView3.DataSource = BindProductsToGridPrototype1(textBox13.Text);
            //dataGridView3.DataSource = BindProductsToGrid(textBox13.Text, textBox14.Text, textBox15.Text);
            string categorySelection = "";
            string manufacturerSelection = "";

            if (checkBox1.Checked == true)
            {
                categorySelection = listBox4.SelectedItem.ToString();
            }
            if (checkBox2.Checked == true)
            {
                manufacturerSelection = listBox5.SelectedItem.ToString();
            }

            //dataGridView3.DataSource = BindProductsToGrid(textBox13.Text, textBox14.Text, textBox15.Text, categorySelection);
            dataGridView3.DataSource = BindProductsToGrid(textBox13.Text, textBox14.Text, textBox15.Text, categorySelection, manufacturerSelection);
            panel13.Show();
        }
        //public void CheckBoxSelected
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
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
        

        private void button31_Click(object sender, EventArgs e)
        {
            listBox7.DataSource = BindReceivedMessages(crtUser);
            HideShowEmailPanels(panel16);
        }
        private void button32_Click(object sender, EventArgs e)
        {
            HideShowEmailPanels(panel17);
        }
        private void button33_Click(object sender, EventArgs e)
        {
            HideShowEmailPanels(panel18);
        }
        private void button34_Click(object sender, EventArgs e)
        {
            HideShowEmailPanels(panel19);
        }
        private void button35_Click(object sender, EventArgs e)
        {
            HideShowEmailPanels(panel20);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if(CheckIfEmailDataInputNotEmpty())
            {
                string[] messageFields = new string[] { Form.ActiveForm.Text, textBox17.Text, textBox18.Text, richTextBox1.Text };
                var newMessage = Messaging.CreateMessage(messageFields);
                if(DBUpdates.WriteMessageToDB(newMessage))
                {
                    MessageBox.Show("Message sent");
                }
                else 
                {
                    MessageBox.Show("Your message could not be sent. Check if receiver name is correct!");
                }         
            }
            else
            {
                MessageBox.Show("Please fill in all required fields");
            }
        }
        public static string GetUser()
        {
            return ActiveForm.Text;
            
        }

        private bool CheckIfEmailDataInputNotEmpty()
        {
            bool correctInputData = false;
            
            if (textBox17.Text != String.Empty
               && textBox18.Text != String.Empty
               && richTextBox1.Text != String.Empty)
            {
                correctInputData = true;
            }

            return correctInputData;
        }
        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            //richTextBox2.Text = 
            //int selection = listBox7.SelectedIndex;
            //richTextBox2.Text = DBUpdates.GetMessage(crtUser, selection);
            //List<string> inboxMessages = DBUpdates.GetMessages(crtUser);
            //MessageBox.Show(selection.ToString());
            //richTextBox2.Text = inboxMessages[selection];
            //panel16.Show();
        }
        private void button37_Click(object sender, EventArgs e)
        {
            int selection = listBox7.SelectedIndex;
            List<string> inboxMessages = DBUpdates.GetMessages(crtUser);
            richTextBox2.Text = inboxMessages[selection];
            //MessageBox.Show(selection.ToString());
            panel16.Show();

        }

        private void HideShowEmailPanels(Panel panel)
        {
            panel16.Hide();
            panel17.Hide();
            panel18.Hide();
            panel19.Hide();
            panel20.Hide();
            panel.Show();
        }
        private void HideEmailPanels()
        {
            panel16.Hide();
            panel17.Hide();
            panel18.Hide();
            panel19.Hide();
            panel20.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
