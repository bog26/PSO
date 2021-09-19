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
        public static void WriteUserPersonalDataToDB(string choice, string input)
        {
            var psContext = new psDBContext();
            string loggedUser = Form.ActiveForm.Text;

            if (InternalDBQueries.CheckForAdminRights(loggedUser))
            {
                var crtUser = psContext.Admins.First(x => x.UserName == loggedUser);
                var pdata = psContext.UserPersonalDatas.Find(crtUser.UserPersonalDataId);
                UserPDataChange(pdata, choice, input);
            }
            else 
            {
                var crtUser = psContext.Clients.First(x => x.UserName == loggedUser);
                var pdata = psContext.UserPersonalDatas.Find(crtUser.UserPersonalDataId);
                UserPDataChange(pdata, choice, input);
            }
            psContext.SaveChanges();
        }

        public static void UserPDataChange(UserPersonalData userData, string choice, string change)
        {
            switch (choice)
            {
                case "FirstName":
                    userData.FirstName = change;
                    MessageBox.Show(choice + ": " + change);
                    break;
                case "LastName":
                    userData.LastName = change;
                    MessageBox.Show(choice + ": " + change);
                    break;
                case "email":
                    userData.Email = change;
                    MessageBox.Show(choice + ": " + change);
                    break;
                case "Telephone":
                    userData.Telephone = change;
                    MessageBox.Show(choice + ": " + change);
                    break;    
            }
        }

        public static void WriteUserAddressToDB(string choice, string input)  
        {
            var psContext = new psDBContext();
            string loggedUser = Form.ActiveForm.Text;

            if (InternalDBQueries.CheckForAdminRights(loggedUser))
            {
                var crtUser = psContext.Admins.First(x => x.UserName == loggedUser);
                var personalAddr = psContext.UserAddresses.Find(crtUser.UserAddressId);
                UserAddressChange(personalAddr, choice, input);

            }
            else
            {
                var crtUser = psContext.Clients.First(x => x.UserName == loggedUser);
                var personalAddr = psContext.UserAddresses.Find(crtUser.UserAddressId);
                UserAddressChange(personalAddr, choice, input);
            }
            psContext.SaveChanges();
        }


        //public static void UserAddressChange(UserAddress userAddress, string choice, string change)
        //public static void UserAddressChange(UserPersonalData userData, string choice, string change)
        public static void UserAddressChange(UserAddress userAddress, string choice, string change)
        {
            switch (choice)
            {
                case "Street":
                    //userData.Address.Street = change;
                    userAddress.Street = change;
                    MessageBox.Show(choice + ": " + change);
                    break;
                case "StreetNr":
                    userAddress.StreetNr = int.Parse(change);
                    MessageBox.Show(choice + ": " + change);
                    break;
                case "City":
                    userAddress.City = change;
                    MessageBox.Show(choice + ": " + change);
                    break;
                case "Region":
                    userAddress.Region = change;
                    MessageBox.Show(choice + ": " + change);
                    break;
                case "Country":
                    userAddress.Country = change;
                    MessageBox.Show(choice + ": " + change);
                    break;
                case "PostalCode":
                    userAddress.PostalCode = int.Parse(change);
                    MessageBox.Show(choice + ": " + change);
                    break;
            }
        }
        public static void WriteNewPassToDB(string newPass)
        {
            var psContext = new psDBContext();
            string loggedUser = Form.ActiveForm.Text;

            if (InternalDBQueries.CheckForAdminRights(loggedUser))
            {
                var crtUser = psContext.Admins.First(x => x.UserName == loggedUser);
                crtUser.Password = newPass;
            }
            else
            {
                var crtUser = psContext.Clients.First(x => x.UserName == loggedUser);
                crtUser.Password = newPass;
            }
            psContext.SaveChanges();
        }



    }
}
