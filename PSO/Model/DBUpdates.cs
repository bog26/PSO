using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSO.Model
{
    public class DBUpdates
    {
        public static void WriteUserPersonalDataToDB(string choice, string text)
        {
            var psContext = new psDBContext();
            string loggedUser = Form.ActiveForm.Text;
            var crtUser = psContext.Admins.First(x => x.UserName == loggedUser);
            var pdata = psContext.UserPersonalDatas.Find(crtUser.UserPersonalDataId);

            switch (choice)
            {
                case "FirstName":
                    pdata.FirstName = text;
                    MessageBox.Show(choice + ": " + text);
                    break;
                case "LastName":
                    pdata.LastName = text;
                    MessageBox.Show(choice + ": " + text);
                    break;
                case "email":
                    pdata.Email = text;
                    MessageBox.Show(choice + ": " + text);
                    break;
                case "Telephone":
                    pdata.Telephone = text;
                    MessageBox.Show(choice + ": " + text);
                    break;
            }
            psContext.SaveChanges();
        }
    }
}
