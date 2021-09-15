using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSO.Model
{
    public class FormElementsDisplay
    {
        public static  void DisplayNewLabel(Label label, int[] position, int[] size, string labelText)
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
    }
}
