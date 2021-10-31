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
        
        public static bool CheckForCorrectPassword(string loggedUser, string password)
        {
            var psContext = new psDBContext();
            bool correctPassword = false;

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

            return correctPassword;
        }

        public static string GetPassword(string loggedUser)
        {
            var psContext = new psDBContext();
            var crtUser = psContext.Admins.First(x => x.UserName == loggedUser);
            return crtUser.Password;
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

        public static int GetWishListSize(string clientName)
        {
            var psContext = new psDBContext();
            var crtClient = psContext.Clients.First(x => x.UserName == clientName);
            var crtWishList = psContext.WishLists.First(x => x.ClientName == clientName);
            int[] PIDArray = crtWishList.getPIDs();
            //var wishList = crtClient.WishList.WishPIDs;
            return PIDArray.Length;
        }

        public static bool IsProductInCart(string user, int PID)
        {
            bool productinCart = false;
            var psContext = new psDBContext();
            var crtClient = psContext.Clients.First(x => x.UserName == user);
            var item = psContext.ShoppingCartItems.Where(x => (x.ProductId == PID) && (x.ClientId == crtClient.Id)).ToList();

            if(item.Count>0)
            {
                productinCart = true;
            }
            return productinCart;
        }

    }
}
