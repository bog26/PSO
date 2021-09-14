using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static bool CheckForCorrectPassword(string password)
        {
            bool correctPassword = false;
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
