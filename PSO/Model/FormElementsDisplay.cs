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
        //private psDBContext psContext;
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
        public static void DisplayNewDataGrid(DataGrid dataGrid, int[] position, int[] size)
        {
            int posX = position[0];
            int posY = position[1];
            int length = size[0];
            int hight = size[1];

            dataGrid.Anchor = (AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left) | AnchorStyles.Right));
            //dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.PreferredColumnWidth = (int)DataGridViewAutoSizeColumnMode.DisplayedCells;

            dataGrid.Location = new System.Drawing.Point(posX, posY);
            
            //dataGrid.Name = "dataGridView1";
            dataGrid.Size = new System.Drawing.Size(length, hight);
            dataGrid.TabIndex = 0;

            Form.ActiveForm.Controls.Add(dataGrid);
        }


        
        public static BindingSource BindDataGrid()
        {
            psDBContext psContext = new psDBContext();

            BindingSource binding = new BindingSource();
            var query = from i in psContext.Admins
                        orderby i.Id
                        select new { i.Id, Name = i.AdminPersonalData.FirstName, LastName = i.AdminPersonalData.LastName };
            binding.DataSource = query.ToList();
            return binding;

        }
        
    }
}
