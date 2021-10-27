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

        /*
        public static int GetWishListSize(string clientName)
        {
            var psContext = new psDBContext();
            var crtClient = psContext.Clients.First(x => x.UserName == clientName);
            var crtWishList = psContext.WishLists.First(x => x.ClientName == clientName);

            //var wishList = crtClient.WishList.WishPIDs;
            return crtWishList.WishPIDs.Count();
        }
        */


        /*
        public static List<int> GetWishList(string clientName)
        {
            List<int> wishList = new List<int>();
            var psContext = new psDBContext();
            var crtClient = psContext.Clients.First(x => x.UserName == clientName);
            wishList = crtClient.WishList;
            return wishList;
        }
        */
        /*
        public static string GetWishListStr(string clientName)
        {
            string wishListStr = "";

            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            List<int> wishListPIDs = new List<int>();
            List<Product> wishListProducts = new List<Product>();
            List<string> wishListProductsSpecs = new List<string>();

            var crtClient = psContext.Clients.First(x => x.UserName == clientName);
            wishListPIDs = crtClient.WishList;

            /*
            foreach (int PID in wishListPIDs)
            {
                Product product = psContext.Products.First(x => x.Id == PID);
                wishListProducts.Add(product);
                wishListStr = wishListStr + product.ProductName +"\n";
            }
            //Product product = psContext.Products.First(x => x.Id == wishListPIDs[0]);
            // wishListStr = product.ProductName.ToString();
            wishListStr = wishListPIDs.Count().ToString();
            return wishListStr;

        }



    */

        /*
         
          */


    }
}
