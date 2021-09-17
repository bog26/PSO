using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSO.Model
{
    public class InternalDBQueries
    {
        
        public static bool CheckForExistingUser(string userName)
        {
            bool exisitingUser = false;
            var psContext = new psDBContext();
            var admins = psContext.Admins.ToList();
            var clients = psContext.Clients.ToList();
            foreach (Admin admin in admins)
            {
                if (userName == admin.UserName)
                {
                    exisitingUser = true;
                }
            }
            foreach (Client client in clients)
            {
                if (userName == client.UserName)
                {
                    exisitingUser = true;
                }
            }
            return exisitingUser;
        }
        //public static bool CheckForCorrectPassword(string password)
        public static bool CheckForCorrectPassword(string loggedUser, string password)
        {
            var psContext = new psDBContext();
            bool correctPassword = false;
            //string loggedUser = Form.ActiveForm.Text;

            if (CheckForAdminRights(loggedUser))
            {
                var crtUser = psContext.Admins.First(x => x.UserName == loggedUser);
                if(crtUser.Password == password)
                {
                    correctPassword = true;
                }
            }
            else
            {
                var crtUser = psContext.Clients.First(x => x.UserName == loggedUser);
                if (crtUser.Password == password)
                {
                    correctPassword = true;
                }
            }

            /*
            var psContext = new psDBContext();
            var admins = psContext.Admins.ToList();
            var clients = psContext.Clients.ToList();
            foreach (Admin admin in admins)
            {
                if (password == admin.Password)
                {
                    correctPassword = true;
                }
            }
            foreach (Client client in clients)
            {
                if (password == client.Password)
                {
                    correctPassword = true;
                }
            }
            */

            return correctPassword;
        }


        public static bool CheckForAdminRights(string userName)
        {
            bool isAdmin = false;

            var psContext = new psDBContext();
            var admins = psContext.Admins.ToList();
            foreach(Admin admin in admins)
            {
                if (userName == admin.UserName)
                {
                    isAdmin = true;
                }
            }

            return isAdmin;
        }


    }
}
