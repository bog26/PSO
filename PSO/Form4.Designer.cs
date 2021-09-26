
using System.Windows.Forms;
using static PSO.Model.FormElementsDisplay;
using static PSO.Model.DBBindings;

namespace PSO
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button14 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN ACCOUNT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(44, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 160);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 125);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Edit user rights";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "User information";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add new Admin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete Account";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(18, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Account administration";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(1070, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 35);
            this.button5.TabIndex = 2;
            this.button5.Text = "LOG OUT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(44, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(183, 128);
            this.panel2.TabIndex = 3;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(24, 97);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(123, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = "Delete Product";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(24, 68);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 23);
            this.button7.TabIndex = 2;
            this.button7.Text = "Products";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(24, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(123, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "Warehause";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(21, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Store administration";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(44, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 189);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(24, 158);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(123, 23);
            this.button13.TabIndex = 5;
            this.button13.Text = "Create offers";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(24, 128);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(123, 23);
            this.button12.TabIndex = 4;
            this.button12.Text = "Statistics";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(24, 98);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(123, 23);
            this.button11.TabIndex = 3;
            this.button11.Text = "Transactions";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(24, 68);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(123, 23);
            this.button10.TabIndex = 2;
            this.button10.Text = "Reviews";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(24, 37);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(123, 23);
            this.button9.TabIndex = 1;
            this.button9.Text = "Clients";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(21, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sales";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button14);
            this.panel4.Location = new System.Drawing.Point(44, 46);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(183, 43);
            this.panel4.TabIndex = 5;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button14.Location = new System.Drawing.Point(21, 4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(126, 36);
            this.button14.TabIndex = 0;
            this.button14.Text = "Messages";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1200, 600);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button1;

        //Form4 manual-added components //TBD
        private void InitializeManualAddedComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            //TBD:
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button22 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button23 = new System.Windows.Forms.Button();

            this.panel9 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button24 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();

            this.panel10 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button25 = new System.Windows.Forms.Button();

            //this.panel8.SuspendLayout();
            //this.SuspendLayout();
            /*
             this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
             */


            DisplayNewPanel(panel8, new int[2] { 550, 82 }, new int[2] { 500, 350 }, "panel8", true);
            this.Controls.Add(this.panel8);
            panel8.Hide();
            int[] panelItemsOriginCoord = new int[2] { 20, 20 };
            int origX = panelItemsOriginCoord[0];
            int origY = panelItemsOriginCoord[1];
            int xMargin = 5;
            int yMargin = 5;
            int xItemsSpace = 40;
            int yItemsSpace = 15;

            string label10Text = "Please add product main characteristics";
            int xPosLabel10 = 3 * xMargin;
            int yPosLabel10 = yMargin;
            int sizeXLabel10 = ClaculateLabelLenght(label10Text);
            int sizeYLabel10 = 24;
            DisplayNewLabelOnPanel(label10, panel8, new int[2] { xPosLabel10, yPosLabel10 }, new int[2]
                { sizeXLabel10, sizeYLabel10 }, label10Text);

            string label11Text = "Category";
            int xPosLabel11 = 3 * xMargin;
            int yPosLabel11 = yPosLabel10 + sizeYLabel10 + 2 * yItemsSpace;
            int sizeXLabel11 = ClaculateLabelLenght(label11Text);
            int sizeYLabel11 = 24;
            DisplayNewLabelOnPanel(label11, panel8, new int[2] { xPosLabel11, yPosLabel11 }, new int[2]
                { sizeXLabel11, sizeYLabel11 }, label11Text);

            int xPosTextBox5 = xPosLabel11;
            int yPosTextBox5 = yPosLabel11 + sizeYLabel11 + yItemsSpace;
            int sizeXTextBox5 = 120;
            int sizeYTextBox5 = 24;
            DisplayNewTextBoxOnPanel(textBox5, panel8, new int[2] { xPosTextBox5, yPosTextBox5 }, new int[2]
                { sizeXTextBox5, sizeYTextBox5 }, "new category");
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);

            int xPosButton22 = xPosTextBox5;
            int yPosButton22 = yPosTextBox5 + sizeYTextBox5 + yItemsSpace;
            int sizeXButton22 = 40;
            int sizeYButton22 = 24;
            DisplayNewButtonOnPanel(button22, panel8, new int[2] { xPosButton22, yPosButton22 }, new int[2]
                { sizeXButton22, sizeYButton22 }, "button22", "Add");
            this.button22.Click += new System.EventHandler(this.button22_Click);


            string label12Text = "Manufacturer";
            int xPosLabel12 = xPosLabel11 + sizeXLabel11 + xItemsSpace * 4;
            int yPosLabel12 = yPosLabel11;
            int sizeXLabel12 = ClaculateLabelLenght(label12Text);
            int sizeYLabel12 = 24;
            DisplayNewLabelOnPanel(label12, panel8, new int[2] { xPosLabel12, yPosLabel12 }, new int[2]
                { sizeXLabel12, sizeYLabel12 }, label12Text);

            int xPosTextBox6 = xPosLabel12;
            int yPosTextBox6 = yPosLabel12 + sizeYLabel12 + yItemsSpace;
            int sizeXTextBox6 = 120;
            int sizeYTextBox6 = 24;
            DisplayNewTextBoxOnPanel(textBox6, panel8, new int[2] { xPosTextBox6, yPosTextBox6 }, new int[2]
                { sizeXTextBox6, sizeYTextBox6 }, "new manufacturer");
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);

            int xPosButton23 = xPosTextBox6;
            int yPosButton23 = yPosTextBox6 + sizeYTextBox6 + yItemsSpace;
            int sizeXButton23 = 40;
            int sizeYButton23 = 24;
            DisplayNewButtonOnPanel(button23, panel8, new int[2] { xPosButton23, yPosButton23 }, new int[2]
                { sizeXButton23, sizeYButton23 }, "button23", "Add");
            this.button23.Click += new System.EventHandler(this.button23_Click);


            DisplayNewPanel(panel9, new int[2] { 550, 82 }, new int[2] { 500, 350 }, "panel9", true);
            this.Controls.Add(this.panel9);
            panel9.Hide();

            string label14Text = "Please add product secondary characteristics";
            int xPosLabel14 = 3 * xMargin;
            int yPosLabel14 = yMargin;
            int sizeXLabel14 = ClaculateLabelLenght(label14Text);
            int sizeYLabel14 = 24;
            DisplayNewLabelOnPanel(label14, panel9, new int[2] { xPosLabel14, yPosLabel14 }, new int[2]
                { sizeXLabel14, sizeYLabel14 }, label14Text);

            string label13Text = "Subcategory";
            int xPosLabel13 = xPosLabel14;
            int yPosLabel13 = yPosLabel14 + sizeYLabel14 + 2 * yItemsSpace;
            int sizeXLabel13 = ClaculateLabelLenght(label13Text);
            int sizeYLabel13 = 24;
            DisplayNewLabelOnPanel(label13, panel9, new int[2] { xPosLabel13, yPosLabel13 }, new int[2]
                { sizeXLabel13, sizeYLabel13 }, label13Text);

            string label15Text = "Category";
            int xPosLabel15 = xPosLabel13 + sizeXLabel13 + 2 * xItemsSpace;
            int yPosLabel15 = yPosLabel13;
            int sizeXLabel15 = ClaculateLabelLenght(label13Text);
            int sizeYLabel15 = 24;
            DisplayNewLabelOnPanel(label15, panel9, new int[2] { xPosLabel15, yPosLabel15 }, new int[2]
                { sizeXLabel15, sizeYLabel15 }, label15Text);

            int xPosTextBox7 = xPosLabel13;
            int yPosTextBox7 = yPosLabel13 + sizeYLabel13 + yItemsSpace;
            int sizeXTextBox7 = 120;
            int sizeYTextBox7 = 24;
            DisplayNewTextBoxOnPanel(textBox7, panel9, new int[2] { xPosTextBox7, yPosTextBox7 }, new int[2]
                { sizeXTextBox7, sizeYTextBox7 }, "new subcategory");
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);

            string listBox1Text = "Select Category";
            int xlistBox1 = xPosLabel15;
            int ylistBox1 = yPosTextBox7;
            int sizeXlistBox1 = 140;
            int sizeYlistBox1 = 90;
            DisplayListBox(listBox1, panel9, new int[2] { xlistBox1, ylistBox1 }, new int[2]
                { sizeXlistBox1, sizeYlistBox1 }, listBox1Text, BindCategories());
            //listBox1.DataSource = BindCategories();
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);

            int xPosButton24 = xPosTextBox7;
            int yPosButton24 = yPosTextBox7 + sizeYTextBox7 + yItemsSpace;
            int sizeXButton24 = 40;
            int sizeYButton24 = 24;
            DisplayNewButtonOnPanel(button24, panel9, new int[2] { xPosButton24, yPosButton24 }, new int[2]
                { sizeXButton24, sizeYButton24 }, "button24", "Add");
            this.button24.Click += new System.EventHandler(this.button24_Click);

            DisplayNewPanel(panel10, new int[2] { 550, 82 }, new int[2] { 500, 350 }, "panel10", true);
            this.Controls.Add(this.panel10);
            panel10.Hide();

            string label16Text = "Please fill all product fields";
            int xPosLabel16 = 3 * xMargin;
            int yPosLabel16 = yMargin;
            int sizeXLabel16 = ClaculateLabelLenght(label16Text);
            int sizeYLabel16 = 24;
            DisplayNewLabelOnPanel(label16, panel10, new int[2] { xPosLabel16, yPosLabel16 }, new int[2]
                { sizeXLabel16, sizeYLabel16 }, label16Text);

            string label17Text = "Product name:";
            int xPosLabel17 = xPosLabel16;
            int yPosLabel17 = yPosLabel16 + sizeYLabel16 + 2 * yItemsSpace;
            int sizeXLabel17 = ClaculateLabelLenght(label17Text);
            int sizeYLabel17 = 24;
            DisplayNewLabelOnPanel(label17, panel10, new int[2] { xPosLabel17, yPosLabel17 }, new int[2]
                { sizeXLabel17, sizeYLabel17 }, label17Text);

            string label18Text = "Product model:";
            int xPosLabel18 = xPosLabel17 + sizeXLabel17 + 4 * xItemsSpace;
            int yPosLabel18 = yPosLabel17;
            int sizeXLabel18 = ClaculateLabelLenght(label17Text);
            int sizeYLabel18 = 24;
            DisplayNewLabelOnPanel(label18, panel10, new int[2] { xPosLabel18, yPosLabel18 }, new int[2]
                { sizeXLabel18, sizeYLabel18 }, label18Text);

            int xPosTextBox8 = xPosLabel17;
            int yPosTextBox8 = yPosLabel17 + sizeYLabel17 + yItemsSpace;
            int sizeXTextBox8 = 130;
            int sizeYTextBox8 = 24;
            DisplayNewTextBoxOnPanel(textBox8, panel10, new int[2] { xPosTextBox8, yPosTextBox8 }, new int[2]
                { sizeXTextBox8, sizeYTextBox8 }, "Product name");
            //textBox8.TextChanged += new EventHandler(textBox8_TextChanged);

            int xPosTextBox9 = xPosLabel18;
            int yPosTextBox9 = yPosLabel18 + sizeYLabel18 + yItemsSpace;
            int sizeXTextBox9 = 130;
            int sizeYTextBox9 = 24;
            DisplayNewTextBoxOnPanel(textBox9, panel10, new int[2] { xPosTextBox9, yPosTextBox9 }, new int[2]
                { sizeXTextBox9, sizeYTextBox9 }, "Product model");
            //textBox9.TextChanged += new EventHandler(textBox9_TextChanged);

            string label19Text = "Manufacturer:";
            int xPosLabel19 = xPosLabel17;
            int yPosLabel19 = yPosTextBox8 + sizeYTextBox8 + yItemsSpace;
            int sizeXLabel19 = ClaculateLabelLenght(label19Text);
            int sizeYLabel19 = 24;
            DisplayNewLabelOnPanel(label19, panel10, new int[2] { xPosLabel19, yPosLabel19 }, new int[2]
                { sizeXLabel19, sizeYLabel19 }, label19Text);

            string label20Text = "Subcategory:";
            int xPosLabel20 = xPosLabel18;
            int yPosLabel20 = yPosTextBox9 + sizeYTextBox9 + yItemsSpace;
            int sizeXLabel20 = ClaculateLabelLenght(label20Text);
            int sizeYLabel20 = 24;
            DisplayNewLabelOnPanel(label20, panel10, new int[2] { xPosLabel20, yPosLabel20 }, new int[2]
                { sizeXLabel20, sizeYLabel20 }, label20Text);

            string listBox2Text = "Select Manufacturer";
            int xlistBox2 = xPosLabel19;
            int ylistBox2 = yPosLabel19 + sizeYLabel19 + yItemsSpace;
            int sizeXlistBox2 = 140;
            int sizeYlistBox2 = 70;
            DisplayListBox(listBox2, panel10, new int[2] { xlistBox2, ylistBox2 }, new int[2]
                { sizeXlistBox2, sizeYlistBox2 }, listBox2Text, BindManufacturers());
            //listBox2.DataSource = BindManufacturers();  
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);

            string listBox3Text = "Select subcategory";
            int xlistBox3 = xPosLabel20;
            int ylistBox3 = yPosLabel20 + sizeYLabel20 + yItemsSpace;
            int sizeXlistBox3 = 140;
            int sizeYlistBox3 = 70;
            DisplayListBox(listBox3, panel10, new int[2] { xlistBox3, ylistBox3 }, new int[2]
                { sizeXlistBox3, sizeYlistBox3 }, listBox3Text, BindSubcategories());
            //listBox2.DataSource = BindManufacturers();
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);

            string label21Text = "Starting stock:";
            int xPosLabel21 = xPosLabel19;
            int yPosLabel21 = ylistBox2 + sizeYlistBox2 + yItemsSpace;
            int sizeXLabel21 = ClaculateLabelLenght(label21Text);
            int sizeYLabel21 = 24;
            DisplayNewLabelOnPanel(label21, panel10, new int[2] { xPosLabel21, yPosLabel21 }, new int[2]
                { sizeXLabel21, sizeYLabel21 }, label21Text);

            string label22Text = "Sell price:";
            int xPosLabel22 = xPosLabel21 + sizeXLabel21 + 2 * xItemsSpace;
            int yPosLabel22 = yPosLabel21;
            int sizeXLabel22 = ClaculateLabelLenght(label22Text);
            int sizeYLabel22 = 24;
            DisplayNewLabelOnPanel(label22, panel10, new int[2] { xPosLabel22, yPosLabel22 }, new int[2]
                { sizeXLabel22, sizeYLabel22 }, label22Text);

            string label23Text = "Supplier price:";
            int xPosLabel23 = xPosLabel22 + sizeXLabel22 + 2 * xItemsSpace;
            int yPosLabel23 = yPosLabel21;
            int sizeXLabel23 = ClaculateLabelLenght(label22Text);
            int sizeYLabel23 = 24;
            DisplayNewLabelOnPanel(label23, panel10, new int[2] { xPosLabel23, yPosLabel23 }, new int[2]
                { sizeXLabel23, sizeYLabel23 }, label23Text);

            int xPosTextBox10 = xPosLabel21;
            int yPosTextBox10 = yPosLabel21 + sizeYLabel21 + yItemsSpace;
            int sizeXTextBox10 = 70;
            int sizeYTextBox10 = 24;
            DisplayNewTextBoxOnPanel(textBox10, panel10, new int[2] { xPosTextBox10, yPosTextBox10 }, new int[2]
                { sizeXTextBox10, sizeYTextBox10 }, "Stock");
            //textBox10.TextChanged += new EventHandler(textBox10_TextChanged);

            int xPosTextBox11 = xPosLabel22;
            int yPosTextBox11 = yPosLabel22 + sizeYLabel22 + yItemsSpace;
            int sizeXTextBox11 = 70;
            int sizeYTextBox11 = 24;
            DisplayNewTextBoxOnPanel(textBox11, panel10, new int[2] { xPosTextBox11, yPosTextBox11 }, new int[2]
                { sizeXTextBox11, sizeYTextBox11 }, "sell price");
            //textBox11.TextChanged += new EventHandler(textBox11_TextChanged);

            int xPosTextBox12 = xPosLabel23;
            int yPosTextBox12 = yPosLabel23 + sizeYLabel22 + yItemsSpace;
            int sizeXTextBox12 = 70;
            int sizeYTextBox12 = 24;
            DisplayNewTextBoxOnPanel(textBox12, panel10, new int[2] { xPosTextBox12, yPosTextBox12 }, new int[2]
                { sizeXTextBox12, sizeYTextBox12 }, "Supplier price");

            string Button25Text = "Add product to DB";
            int xPosButton25 = xPosLabel16 + sizeXLabel16 + 3 * xItemsSpace;
            int yPosButton25 = yPosLabel16;
            int sizeXButton25 = ClaculateLabelLenght(Button25Text) * 2;
            int sizeYButton25 = 24;
            DisplayNewButtonOnPanel(button25, panel10, new int[2] { xPosButton25, yPosButton25 }, new int[2]
                { sizeXButton25, sizeYButton25 }, "button25", Button25Text);
            this.button25.Click += new System.EventHandler(this.button25_Click);
            

            /*

            
             */


            //Form4
            /*
            this.Controls.Add(this.panel8);
            this.Name = "Form4";
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
            */

        }

        //TBD:
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button23;

        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button24;

        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button button25;

        /*
        private System.Windows.Forms.DataGridView dataGridView1;
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
         */
    }
}