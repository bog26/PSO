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

        
        public static BindingSource BindAllUserDataToGrid()
        {
            psDBContext psContext = new psDBContext();

            BindingSource binding = new BindingSource();
            var query = from i in psContext.Admins
                        orderby i.Id
                        select new { i.Id, UserName=i.UserName, Name = i.UserInfo.FirstName, LastName = i.UserInfo.LastName, 
                                    BirthDate = i.UserInfo.BirthDate, email = i.UserInfo.Email, 
                                    Telephone = i.UserInfo.Telephone };
            binding.DataSource = query.ToList();
            return binding;
        }
        
        public static BindingSource BindCrtUserDataToGrid(string userName)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            var queryAdmin = from user in psContext.Admins
                        where user.UserName == userName
                        select new
                        {
                            UserName = user.UserName,
                            Name = user.UserInfo.FirstName,
                            LastName = user.UserInfo.LastName,
                            BirthDate = user.UserInfo.BirthDate,
                            email = user.UserInfo.Email,
                            Telephone = user.UserInfo.Telephone
                        };
            var queryClient = from user in psContext.Clients
                             where user.UserName == userName
                             select new
                             {
                                 UserName = user.UserName,
                                 Name = user.UserInfo.FirstName,
                                 LastName = user.UserInfo.LastName,
                                 BirthDate = user.UserInfo.BirthDate,
                                 email = user.UserInfo.Email,
                                 Telephone = user.UserInfo.Telephone
                             };

            if(InternalDBQueries.CheckForAdminRights(userName))
            {
                binding.DataSource = queryAdmin.ToList();
            }
            else 
            {
                binding.DataSource = queryClient.ToList();
            }
            return binding;
        }
        public static BindingSource BindCrtUserAddressToGrid(string userName)
        {
            psDBContext psContext = new psDBContext();

            BindingSource binding = new BindingSource();
            var query = from user in psContext.Admins
                        where user.UserName == userName
                        select new
                        {
                            Street = user.UserInfo.Address.Street,
                            StreetNr = user.UserInfo.Address.StreetNr,
                            City = user.UserInfo.Address.City,
                            Region = user.UserInfo.Address.Region,
                            Country = user.UserInfo.Address.Country,
                            PostalCode = user.UserInfo.Address.PostalCode
                        };
            binding.DataSource = query.ToList();
            return binding;
        }


    }
}
