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
            InitializeManualAddedComponent();
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

        /*
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
        */

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView5.DataSource = BindCrtUserDataToGrid(crtUser);
            dataGridView6.DataSource = BindCrtUserAddressToGrid(crtUser);
            HideShowAllPanels(panelUserInfo);

            /*
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
            */
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = e.RowIndex;
            //MessageBox.Show($"row {selection} clicked"); // selection test ok
            string rawText;
            bool encryption;
            if (textBox1.Text != string.Empty)
            {
                rawText = DBUpdates.GetMessage(crtUser, selection, textBox1.Text);

                if (!DBUpdates.IsMessageEncrypted(crtUser, selection, textBox1.Text))
                {
                    encryption = false;
                }
                else
                {
                    encryption = true;
                }
            }
            else
            {
                rawText = DBUpdates.GetMessage(crtUser, selection);
                if (!DBUpdates.IsMessageEncrypted(crtUser, selection))
                {
                    encryption = false;
                }
                else
                {
                    encryption = true;
                }
            }
            if (!encryption)
            {
                richTextBox1.Text = rawText;
            }
            else
            {
                string key = "abracadabra";
                string decryptedMessage = Encryption.StringDecrypt(rawText, key);
                richTextBox1.Text = decryptedMessage;
            }
            DBUpdates.ReadMsg(crtUser, selection);
            panelInbox1.Show();
        }



        private void button11_Click(object sender, EventArgs e)
        {

        }
        private void button12_Click(object sender, EventArgs e)
        {

        }
        private void button13_Click(object sender, EventArgs e)
        {


        }
        private void button14_Click(object sender, EventArgs e)
        {

        }
        /*
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
        */
        private void ShoWUserInformationFormElements()
        {
            /*
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
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //HideUserInformationFormElements();
            //panelMessage1.Show();
            HideShowAllPanels(panelMessage1);
        }
        private void HideUserInformationFormElements()
        {
            /*
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
                */

        }
        /*
            private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
            {

            }

            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {

            }
        */
        private void HideShowEmailPanels(Panel panel)
        {
            panelInbox1.Hide();
            panelSent1.Hide();
            panelDeleted1.Hide();
            panelSpam1.Hide();
            panelCompose1.Hide();
            panel.Show();
        }
        private void HideShowAllPanels(Panel panel)
        {
            panelMessage1.Hide();
            panelInbox1.Hide();
            panelSent1.Hide();
            panelDeleted1.Hide();
            panelSpam1.Hide();
            panelCompose1.Hide();
            panelUserInfo.Hide();
            panelProducts.Hide();
            panelWishList.Hide();
            panel.Show();
        }

        private void button15_Click(object sender, EventArgs e) //Wish list
        {
            HideShowAllPanels(panelWishList);
        }

            private void button16_Click(object sender, EventArgs e) //Inbox
        {
            dataGridView1.DataSource = BindInboxMessagesToGridView(crtUser);
            HideShowEmailPanels(panelInbox1);
        }
        private void button17_Click(object sender, EventArgs e) //Sent
        {
            dataGridView2.DataSource = BindSentMessagesToGridView(crtUser);
            HideShowEmailPanels(panelSent1);
        }

        private void button18_Click(object sender, EventArgs e) //Deleted
        {
            dataGridView3.DataSource = BindDeletedMessagesToGridView(crtUser);
            HideShowEmailPanels(panelDeleted1);
        }
        private void button19_Click(object sender, EventArgs e) //spam
        {
            dataGridView4.DataSource = BindSpamMessagesToGridView(crtUser);
            HideShowEmailPanels(panelSpam1);
        }
        private void button20_Click(object sender, EventArgs e) //compose
        {
            HideShowEmailPanels(panelCompose1);
        }

        private void button21_Click(object sender, EventArgs e) //Delete
        {
            int selection = dataGridView1.CurrentCell.RowIndex;
            DBUpdates.DeleteReceiverMsg(crtUser, selection);
        }

        private void button22_Click(object sender, EventArgs e) //Spam
        {
            int selection = dataGridView1.CurrentCell.RowIndex;
            DBUpdates.SpamMsg(crtUser, selection);
        }
        private void button23_Click(object sender, EventArgs e) //"Reply"
        {
            string[] messageFields = MessageReplyFieldsInit();

            string receiver;
            string title;
            string message;

            FillReplyMessage(messageFields, out receiver, out title, out message);
            textBox2.Text = receiver;
            textBox3.Text = title;
            richTextBox5.Text = message;

            HideShowEmailPanels(panelCompose1);
        }
        private void button24_Click(object sender, EventArgs e) //"FWD"
        {
            string[] messageFields = MessageFWDFieldsInit();
            string title;
            string message;

            FillFwdMessage(messageFields, out title, out message);
            textBox2.Text = "";
            textBox3.Text = title;
            richTextBox5.Text = message;
            HideShowEmailPanels(panelCompose1);
        }

        private void button25_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != string.Empty)
            {
                dataGridView4.DataSource = BindInboxSearchMessagesToGridView(crtUser, textBox1.Text);
                HideShowEmailPanels(panelInbox1);
            }

        }

        private string[] MessageReplyFieldsInit()
        {
            //int selection = listBox7.SelectedIndex;
            int selection = dataGridView1.CurrentCell.RowIndex;
            string receiverText = DBUpdates.GetReplyReceiver(crtUser, selection);
            string titleText = "re: " + DBUpdates.GetReplyTitle(crtUser, selection);
            string messageText = "\n" + richTextBox1.Text;
            string[] messageFields = new string[3] { receiverText, titleText, messageText };
            return messageFields;
        }
        private string[] MessageFWDFieldsInit()
        {
            //int selection = listBox7.SelectedIndex;
            int selection = dataGridView1.CurrentCell.RowIndex;
            StringBuilder title = new StringBuilder();
            title.Append("Fwd: ");
            title.Append(DBUpdates.GetReplyTitle(crtUser, selection));
            string titleText = title.ToString();
            string messageText = richTextBox1.Text;
            string[] messageFields = new string[2] { titleText, messageText };
            return messageFields;
        }

        private void FillReplyMessage(string[] messageFields, out string receiverBox, out string titleBox, out string messageBox)
        {
            receiverBox = messageFields[0];
            titleBox = messageFields[1];
            messageBox = messageFields[2];
        }
        private void FillFwdMessage(string[] messageFields, out string titleBox, out string messageBox)
        {
            titleBox = messageFields[0];
            messageBox = messageFields[1];
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = e.RowIndex;
            string rawText = DBUpdates.GetSentMessage(crtUser, selection);
            DisplayClickedMessage(selection, richTextBox2, panelSent1, rawText, DBUpdates.IsSentMessageEncrypted, DBUpdates.ReadSentMsg, crtUser);
        }
        private void button26_Click(object sender, EventArgs e)
        {
            int selection = dataGridView2.CurrentCell.RowIndex;
            DBUpdates.DeleteSenderMsg(crtUser, selection);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = e.RowIndex;
            string rawText = DBUpdates.GetDeletedMessage(crtUser, selection);
            DisplayClickedMessage(selection, richTextBox3, panelDeleted1, rawText, DBUpdates.IsDeletedMessageEncrypted, DBUpdates.ReadDeletedMsg, crtUser);
        }
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selection = e.RowIndex;
            string rawText = DBUpdates.GetSpamMessage(crtUser, selection);
            DisplayClickedMessage(selection, richTextBox4, panelSpam1, rawText, DBUpdates.IsSpamMessageEncrypted, DBUpdates.ReadSpamMsg, crtUser);
        }

        private void button27_Click(object sender, EventArgs e) //"Send"
        {
            if (CheckIfEmailDataInputNotEmpty())
            {

                string withEncryption = EncriptionRequested();
                string messageBody;
                if (withEncryption == "true")
                {
                    string crtUser = IOMethods.GetUserName();
                    string key = "abracadabra";
                    string encryptedMessage = Encryption.StringEncrypt(richTextBox1.Text, key);
                    messageBody = encryptedMessage;
                }
                else
                {
                    messageBody = richTextBox1.Text;
                }
                string[] messageFields = new string[] { Form.ActiveForm.Text, textBox2.Text, textBox3.Text, messageBody, withEncryption };
                var newMessage = Messaging.CreateMessage(messageFields);
                if (DBUpdates.WriteMessageToDB(newMessage))
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

        private string EncriptionRequested()
        {
            string withEncryption = "false";
            if (checkBox1.Checked)
            {
                withEncryption = "true";
            }
            return withEncryption;
        }

        private bool CheckIfEmailDataInputNotEmpty()
        {
            bool correctInputData = false;

            if (textBox2.Text != String.Empty
               && textBox3.Text != String.Empty
               && richTextBox5.Text != String.Empty)
            {
                correctInputData = true;
            }

            return correctInputData;
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView5.Rows[0].Cells[e.ColumnIndex].Value != null && e.ColumnIndex >= 1)
            {
                string cellContent = dataGridView5.Rows[0].Cells[e.ColumnIndex].Value.ToString();
                textBox4.Text = cellContent;
                textBox4.Refresh();
            }
        }
        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView6.Rows[0].Cells[e.ColumnIndex].Value != null && e.ColumnIndex >= 1)
            {
                string cellContent = dataGridView6.Rows[0].Cells[e.ColumnIndex].Value.ToString();
                textBox5.Text = cellContent;
                textBox5.Refresh();
            }
        }

        private void button28_Click(object sender, EventArgs e) //"update"
        {
            string value = textBox4.Text;
            int activeCellIndex = dataGridView5.CurrentCell.ColumnIndex;
            string activeColumn = dataGridView5.Columns[activeCellIndex].Name;
            UpdateDataGridMessageBox(activeColumn, value);
            DBUpdates.WriteUserPersonalDataToDB(activeColumn, value);
            dataGridView5.DataSource = BindCrtUserDataToGrid(crtUser);
            HideShowAllPanels(panelUserInfo);
        }

        private void button29_Click(object sender, EventArgs e) //"update"
        {
            string value = textBox5.Text;
            int activeCellIndex = dataGridView6.CurrentCell.ColumnIndex;
            string activeColumn = dataGridView6.Columns[activeCellIndex].Name;
            UpdateDataGridMessageBox(activeColumn, value);
            DBUpdates.WriteUserAddressToDB(activeColumn, value);
            dataGridView6.DataSource = BindCrtUserAddressToGrid(crtUser);
            HideShowAllPanels(panelUserInfo);
        }

        private void button30_Click(object sender, EventArgs e) //"Change Password"
        {
            textBox6.Text = "old password";
            textBox7.Text = "new password";
            textBox6.Show();
            textBox7.Show();
            button31.Show();
        }

        private void button31_Click(object sender, EventArgs e) //"Update Password"
        {
            if (InternalDBQueries.CheckForCorrectPassword(Form.ActiveForm.Text, textBox6.Text))
            {
                string newPassVal = textBox7.Text;
                DBUpdates.WriteNewPassToDB(newPassVal);
                MessageBox.Show("password changed");
            }
            else
            {
                MessageBox.Show("wrong password");
            }
            textBox6.Hide();
            textBox7.Hide();
            button31.Hide();
        }

        private void UpdateDataGridMessageBox(string column, string value)
        {
            MessageBox.Show("updating " + column + " with " + value);
        }

        private void button6_Click(object sender, EventArgs e) //"Products"
        {
            HideShowAllPanels(panelProducts);
        }

        private void button32_Click(object sender, EventArgs e) //"Search"
        {
            ProductsQuery();
            panelProducts.Show();
        }

        private void ProductsQuery()
        {
            
            string categorySelection = "";
            string manufacturerSelection = "";

            if (checkBox2.Checked == true)
            {
                categorySelection = listBox1.SelectedItem.ToString();
            }
            if (checkBox3.Checked == true)
            {
                manufacturerSelection = listBox2.SelectedItem.ToString();
            }
            dataGridView7.DataSource = BindProductsToGridForClient(textBox8.Text, textBox9.Text, textBox10.Text, categorySelection, manufacturerSelection);
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int columnHeadIndex = -1;
            int rowSelection = e.RowIndex;
            int productID = Int32.Parse( dataGridView7.Rows[rowSelection].Cells[0].Value.ToString());

            if (e.RowIndex != columnHeadIndex)
            {
                
                richTextBox6.Text = DBUpdates.GetProductSpec(productID);
                richTextBox6.Refresh();
                panelProducts.Show();
            }
        }
        private void button33_Click(object sender, EventArgs e) //"Add to cart"
        {
            MessageBox.Show("Added to cart");
        }
        private void button34_Click(object sender, EventArgs e) //"Add to wishlist"
        {

            if (dataGridView7.CurrentCell != null)
            {
                int rowIndex = Int32.Parse(dataGridView7.CurrentCell.RowIndex.ToString());
                int productID = Int32.Parse(dataGridView7.Rows[rowIndex].Cells[0].Value.ToString());
                DBUpdates.SaveProductToWishlist(crtUser, productID);
                //DBUpdates.SaveProductToWishlist(crtUser, productID);
                MessageBox.Show($"product with PID {productID} added to wishlist");
                
            }
            else 
            {
                MessageBox.Show("please select a product");
            }
            MessageBox.Show($"size of wish list: {InternalDBQueries.GetWishListSize(crtUser)} ");

        }

        private void button36_Click(object sender, EventArgs e) //"Add to cart"
        {
            //MessageBox.Show(InternalDBQueries.GetWishListStr(crtUser));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
