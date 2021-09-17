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
        public static void WriteUserAddressToDB(string choice, string text)  //WIP
        {
            var psContext = new psDBContext();
            string loggedUser = Form.ActiveForm.Text;
            var crtUser = psContext.Admins.First(x => x.UserName == loggedUser);
            //var personalAddr = psContext.UserAddresses.Find(crtUser.UserAddressId);
            var personalAddr = psContext.UserAddresses.Find(crtUser.Id);
            switch (choice)
            {
                case "Street":
                    personalAddr.Street = text;
                    MessageBox.Show(choice + ": " + text);
                    break;
                case "StreetNr":
                    personalAddr.StreetNr = int.Parse(text);
                    MessageBox.Show(choice + ": " + text);
                    break;
                case "City":
                    personalAddr.City = text;
                    MessageBox.Show(choice + ": " + text);
                    break;
                case "Region":
                    personalAddr.Region = text;
                    MessageBox.Show(choice + ": " + text);
                    break;
                case "Country":
                    personalAddr.Country = text;
                    MessageBox.Show(choice + ": " + text);
                    break;
                case "PostalCode":
                    personalAddr.PostalCode = int.Parse(text);
                    MessageBox.Show(choice + ": " + text);
                    break;
            }
            psContext.SaveChanges();
        }



    }
}
