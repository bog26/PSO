using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PSO.Model;


namespace PSO.Model
{
    public class FormElementsDisplay
    {
        public static void DisplayNewLabel(Label label, int[] position, int[] size, string labelText)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = SystemColors.HotTrack;
            label.BackColor = Color.LightGray;
            label.Location = new Point(posX, posY);
            label.Name = labelText;
            label.Size = new Size(length, hight);
            label.TabIndex = 0;
            label.Text = labelText;
            Form.ActiveForm.Controls.Add(label);
        }
        public static void DisplayNewLabelOnPanel(Label label, Panel panel, int[] position, int[] size, string labelText)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            label.AutoSize = true;
            label.Font = new Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.ForeColor = SystemColors.HotTrack;
            label.BackColor = Color.LightGray;
            label.Location = new Point(posX, posY);
            label.Name = labelText;
            label.Size = new Size(length, hight);
            label.TabIndex = 0;
            label.Text = labelText;
            panel.Controls.Add(label);
           
        }


        public static void DisplayNewDataGridView(DataGridView dataGridView, int[] position, int[] size)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            dataGridView.Anchor = (AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left) | AnchorStyles.Right));
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(posX, posY);
            dataGridView.Size = new Size(length, hight);
            dataGridView.TabIndex = 0;
            Form.ActiveForm.Controls.Add(dataGridView);
        }
        public static void DisplayNewDataGridViewOnPanel(DataGridView dataGridView, Panel panel, int[] position, int[] size)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            dataGridView.Anchor = (AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left) | AnchorStyles.Right));
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(posX, posY);
            dataGridView.Size = new Size(length, hight);
            dataGridView.TabIndex = 0;
            panel.Controls.Add(dataGridView);
        }


        public static void DisplayNewTextBox(TextBox textBox, int[] position, int[] size, string labelText)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            textBox.Location = new Point(posX, posY);
            textBox.Name = labelText;
            textBox.Size = new Size(length, hight);
            textBox.TabIndex = 0;
            textBox.Text = labelText;
            Form.ActiveForm.Controls.Add(textBox);
        }
        public static void DisplayNewTextBoxOnPanel(TextBox textBox, Panel panel, int[] position, int[] size, string labelText)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            textBox.Location = new Point(posX, posY);
            textBox.Name = labelText;
            textBox.Size = new Size(length, hight);
            textBox.TabIndex = 0;
            textBox.Text = labelText;
            panel.Controls.Add(textBox);
        }

        public static void DisplayNewButton(Button button, int[] position, int[] size, string name, string buttonText)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            button.Location = new Point(posX, posY);
            button.Name = name;
            button.Size = new Size(length, hight);
            button.Text = buttonText;
            button.UseVisualStyleBackColor = true;
            Form.ActiveForm.Controls.Add(button);
        }

        public static void DisplayNewButtonOnPanel(Button button, Panel panel, int[] position, int[] size, string name, string buttonText)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            button.Location = new Point(posX, posY);
            button.Name = name;
            button.Size = new Size(length, hight);
            button.Text = buttonText;
            button.UseVisualStyleBackColor = true;
            panel.Controls.Add(button);
        }


        public static void DisplayNewPanel(Panel panel, int[] position, int[] size, string name, bool withBorder)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];
            panel.Location = new Point(posX, posY);
            panel.Name = name;
            panel.Size = new Size(length, hight);
            if(withBorder)
            {
                panel.BorderStyle = BorderStyle.FixedSingle;
            }
            Form.ActiveForm.Controls.Add(panel);
        }

        public static void clearPanel(Panel panel)
        {
            panel.Controls.Clear();
        }

        public static int ClaculateLabelLenght(string labelText)
        {
            int length = labelText.Length * 5;
            return length;
        }

    }
}
