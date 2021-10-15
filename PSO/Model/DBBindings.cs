using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Data.Entity;


namespace PSO.Model
{
    public class DBBindings
    {
        public static BindingSource BindAllUserDataToGrid()
        {
            psDBContext psContext = new psDBContext();

            BindingSource binding = new BindingSource();
            var query = from i in psContext.Admins
                        orderby i.Id
                        select new
                        {
                            i.Id,
                            UserName = i.UserName,
                            Name = i.UserInfo.FirstName,
                            LastName = i.UserInfo.LastName,
                            BirthDate = i.UserInfo.BirthDate,
                            email = i.UserInfo.Email,
                            Telephone = i.UserInfo.Telephone
                        };
            binding.DataSource = query.ToList();
            return binding;
        }

        public static BindingSource BindCrtUserDataToGrid(string userName)
        {

            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            //new
            //var query = UserDataQuery(userName, psContext); // not ok
            //binding.DataSource = query;
            //new


            var queryAdmin = from user in psContext.Admins
                             where user.UserName == userName
                             select new
                             {
                                 UserName = user.UserName,
                                 FirstName = user.UserInfo.FirstName,
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
                                  FirstName = user.UserInfo.FirstName,
                                  LastName = user.UserInfo.LastName,
                                  BirthDate = user.UserInfo.BirthDate,
                                  email = user.UserInfo.Email,
                                  Telephone = user.UserInfo.Telephone
                              };

            //BindingSource binding = new BindingSource();
            //var queryAdmin = UserQuery.UserDataQuery  //TBD


            if (InternalDBQueries.CheckForAdminRights(userName))
            {
                binding.DataSource = queryAdmin.ToList();
            }
            else
            {
                binding.DataSource = queryClient.ToList();
            }
            return binding;


            /* //TBD
            var query = UserDataQuery(userName, psContext); // not ok
            binding.DataSource = query;

            return binding;
            */

            //new
            //return binding;
            //new

        }

        //TBD:
        private static IEnumerable<Object> UserDataQuery(string userName, psDBContext psContext)
        {
            IUser loggedUser;
            if (InternalDBQueries.CheckForAdminRights(userName))
            {
                loggedUser = psContext.Admins.First(x => x.UserName == userName);
            }
            else
            {
                loggedUser = psContext.Clients.First(x => x.UserName == userName);
            }


            var newData = new  //null obj
            {
                UserName = loggedUser.UserName,
                FirstName = loggedUser.UserInfo.FirstName,
                LastName = loggedUser.UserInfo.LastName,
                BirthDate = loggedUser.UserInfo.BirthDate,
                email = loggedUser.UserInfo.Email,
                Telephone = loggedUser.UserInfo.Telephone
            };


            if (loggedUser.GetType() == typeof(Admin))
            {
                var query = from user in psContext.Admins
                            where user.UserName == userName
                            select newData
                            ;

                return query;
            }
            else
            {
                var query = from user in psContext.Clients
                            where user.UserName == userName
                            select newData;

                return query;
            }

        }


        public static BindingSource BindCrtUserAddressToGrid(string userName)
        {
            psDBContext psContext = new psDBContext();

            BindingSource binding = new BindingSource();
            var queryAdmin = from user in psContext.Admins
                             where user.UserName == userName
                             select new

                             {
                                 Street = user.UserAddress.Street,
                                 StreetNr = user.UserAddress.StreetNr,
                                 City = user.UserAddress.City,
                                 Region = user.UserAddress.Region,
                                 Country = user.UserAddress.Country,
                                 PostalCode = user.UserAddress.PostalCode
                             };

            var queryClient = from user in psContext.Clients
                              where user.UserName == userName
                              select new
                              {
                                  Street = user.UserAddress.Street,
                                  StreetNr = user.UserAddress.StreetNr,
                                  City = user.UserAddress.City,
                                  Region = user.UserAddress.Region,
                                  Country = user.UserAddress.Country,
                                  PostalCode = user.UserAddress.PostalCode
                              };



            if (InternalDBQueries.CheckForAdminRights(userName))
            {
                binding.DataSource = queryAdmin.ToList();
            }
            else
            {
                binding.DataSource = queryClient.ToList();
            }
            return binding;
        }
        public static BindingSource BindCategories()
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();
            var queryCategory = from category in psContext.ProductCategories
                                select category.Name;
            //{ category.Name };
            binding.DataSource = queryCategory.ToList();
            return binding;
        }
        public static BindingSource BindManufacturers()
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();
            var queryManufacturers = from manufacturer in psContext.Manufacturers
                                     select manufacturer.Name;
            //{ category.Name };
            binding.DataSource = queryManufacturers.ToList();
            return binding;
        }
        public static BindingSource BindSubcategories()
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();
            var querySubcategories = from subcategory in psContext.ProductSubCategories
                                     select subcategory.Name;
            binding.DataSource = querySubcategories.ToList();
            return binding;
        }
        public static BindingSource BindReceivedMessages(string user)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();
            var queryReceivedMessages = from message in psContext.Messages
                                where message.Receiver == user
                                select message.MessageTitle;
            binding.DataSource = queryReceivedMessages.ToList();
            return binding;
        }

        public static BindingSource BindProductsToGrid()
        {
            psDBContext psContext = new psDBContext();

            BindingSource binding = new BindingSource();
            
            var queryProducts = from product in psContext.Products
                                select new
                                {
                                    Model = product.Model,
                                    Category = product.SubCategory.Category,
                                    Subcategory = product.SubCategory,
                                    Manufacturer = product.Manufacturer,
                                    Stock = product.Stock,
                                    ManufPrice = product.crtManufacturerPrice,
                                    SellPrice = product.crtSellPrice,

                                };

            binding.DataSource = queryProducts.ToList();

            return binding;
        }
        public static BindingSource BindProductsToGrid(string keyword, string minPriceStr, string maxPriceStr)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            decimal minPrice;
            decimal maxPrice;
            

            var queryProducts = psContext.Products.Where(x => x.ProductName != " ");
            if (keyword != string.Empty)
            {
                queryProducts = queryProducts.Where(x => x.ProductName.Contains(keyword));
            }
            if(decimal.TryParse(minPriceStr, out minPrice))
            {
                queryProducts = queryProducts.Where(x => x.crtSellPrice > minPrice);
            }
            if (decimal.TryParse(maxPriceStr, out maxPrice))
            {
                queryProducts = queryProducts.Where(x => x.crtSellPrice < maxPrice);
            }

            var queryProductsReturn = from product in queryProducts
                                      select new
                                      {
                                          Name = product.ProductName,
                                          Model = product.Model,
                                          Category = product.SubCategory.Category,
                                          Subcategory = product.SubCategory,
                                          Manufacturer = product.Manufacturer,
                                          Stock = product.Stock,
                                          ManufPrice = product.crtManufacturerPrice,
                                          SellPrice = product.crtSellPrice,
                                      };

            binding.DataSource = queryProductsReturn.ToList();
            return binding;
        }
        public static BindingSource BindProductsToGrid(string keyword, string minPriceStr, string maxPriceStr, string category, string manufacturer)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();
            
            decimal minPrice;
            decimal maxPrice;
            int maxAllowedResults =500;

            var queryProducts = psContext.Products.Where(x => x.ProductName != " ").Take(maxAllowedResults);

            if (manufacturer != String.Empty)
            {
                queryProducts = psContext.Products.Where(x => x.Manufacturer.Name == manufacturer);
            }

            if (category != String.Empty)
            {
                queryProducts = psContext.Products.Where(x => x.SubCategory.Category.Name == category);
            }

            if (keyword != string.Empty)
            {
                queryProducts = queryProducts.Where(x => x.ProductName.Contains(keyword));
            }
            if (decimal.TryParse(minPriceStr, out minPrice))
            {
                queryProducts = queryProducts.Where(x => x.crtSellPrice > minPrice);
            }
            if (decimal.TryParse(maxPriceStr, out maxPrice))
            {
                queryProducts = queryProducts.Where(x => x.crtSellPrice < maxPrice);
            }

            var queryProductsReturn = from product in queryProducts
                                      select new
                                      {
                                          PID = product.Id,
                                          Name = product.ProductName,
                                          Model = product.Model,
                                          Category = product.SubCategory.Category,
                                          Subcategory = product.SubCategory,
                                          Manufacturer = product.Manufacturer,
                                          Stock = product.Stock,
                                          ManufPrice = product.crtManufacturerPrice,
                                          SellPrice = product.crtSellPrice,
                                      };

            binding.DataSource = queryProductsReturn.ToList();
            return binding;
        }

        public static BindingSource BindProductsToGrid(string keyword, string minPriceStr, string maxPriceStr, string category)
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            decimal minPrice;
            decimal maxPrice;

            //var queryProducts = psContext.Products.Where(x => x.SubCategory.Category.Name == category);
            //var queryProducts = psContext.Products.Where(x => x.ProductName != " ");

            var queryProducts = psContext.Products.Where(x => x.ProductName != " ");
            if(category != String.Empty)
            {
                queryProducts = psContext.Products.Where(x => x.SubCategory.Category.Name == category);
            }

            if (keyword != string.Empty)
            {
                queryProducts = queryProducts.Where(x => x.ProductName.Contains(keyword));
            }
            if (decimal.TryParse(minPriceStr, out minPrice))
            {
                queryProducts = queryProducts.Where(x => x.crtSellPrice > minPrice);
            }
            if (decimal.TryParse(maxPriceStr, out maxPrice))
            {
                queryProducts = queryProducts.Where(x => x.crtSellPrice < maxPrice);
            }

            var queryProductsReturn = from product in queryProducts
                                      select new
                                      {
                                          
                                          Name = product.ProductName,
                                          Model = product.Model,
                                          Category = product.SubCategory.Category,
                                          Subcategory = product.SubCategory,
                                          Manufacturer = product.Manufacturer,
                                          Stock = product.Stock,
                                          ManufPrice = product.crtManufacturerPrice,
                                          SellPrice = product.crtSellPrice,
                                      };

            binding.DataSource = queryProductsReturn.ToList();
            return binding;
        }
       

        public static BindingSource BindProductsToGridPrototype() //ok
        {
            psDBContext psContext = new psDBContext();

            BindingSource binding = new BindingSource();
            string productModel = "Iphone";
            string category = "Mobile";
            string subcategory = "IOS Smartphones";
            string manufacturer = "Apple";
            var queryProducts = from product in psContext.Products
                                where
                                      product.SubCategory.Name == subcategory &&
                                      product.Manufacturer.Name == manufacturer
                                select new
                                {
                                    Model = product.Model,
                                    Category = product.SubCategory.Category,
                                    Subcategory = product.SubCategory,
                                    Manufacturer = product.Manufacturer,
                                    Stock = product.Stock,
                                    ManufPrice = product.crtManufacturerPrice,
                                    SellPrice = product.crtSellPrice,
                                };

            binding.DataSource = queryProducts.ToList();
            return binding;
        }

        public static BindingSource BindProductsToGridPrototype1(string keyword) 
        {
            psDBContext psContext = new psDBContext();
            BindingSource binding = new BindingSource();

            var queryProducts = psContext.Products.Where(x => x.ProductName != " ");
            if (keyword != string.Empty)
            {
                queryProducts = queryProducts.Where(x => x.ProductName.Contains(keyword));
            }

            var queryProductsReturn = from product in queryProducts
                                      select new
                                      {
                                          Name = product.ProductName,
                                          Model = product.Model,
                                          Category = product.SubCategory.Category,
                                          Subcategory = product.SubCategory,
                                          Manufacturer = product.Manufacturer,
                                          Stock = product.Stock,
                                          ManufPrice = product.crtManufacturerPrice,
                                          SellPrice = product.crtSellPrice,
                                      };

            binding.DataSource = queryProductsReturn.ToList();
            return binding;
        }


            public static BindingSource BindProductsToGridPrototype1() //WIP
        {
            //DateTime startTime = DateTime.Now;

            psDBContext psContext = new psDBContext();

            BindingSource binding = new BindingSource();
            string productModel = "Iphone";
            string category = "Mobile";
            string subcategory = "IOS Smartphones";
            string manufacturer = "Apple";
            int minStock = 40;
            decimal maxSellPrice = 300;
            string searchWord1 = "5G";
            string searchWord2 = "Android";
            string searchWord3 = "Black";

            var queryProducts = psContext.Products.Where(x=>x.ProductName!=" ");
            queryProducts = queryProducts.Where(x => x.ProductName.Contains(searchWord3)); //ok
            queryProducts = queryProducts.Where(x => x.ProductName.Contains(searchWord1)); //ok
            queryProducts = queryProducts.Where(x => x.crtSellPrice < maxSellPrice); //ok
            queryProducts = queryProducts.Where(x => x.Stock >= minStock);  //ok
            //queryProducts = queryProducts.Where(x => x.SubCategory.Category.Name == category);    //ok
            //queryProducts = queryProducts.Where(x => x.SubCategory.Name == subcategory);  //ok
            //queryProducts = queryProducts.Where(x => x.Manufacturer.Name == manufacturer);    //ok

            //var queryProducts = psContext.Products.Where( x =>x.SubCategory.Name == subcategory); //ok
            //queryProducts = queryProducts.Where(x => x.Manufacturer.Name == manufacturer);  //ok

            var queryProductsReturn = from product in queryProducts
                                      select new
                                      {
                                          Name = product.ProductName,
                                          Model = product.Model,
                                          Category = product.SubCategory.Category,
                                          Subcategory = product.SubCategory,
                                          Manufacturer = product.Manufacturer,
                                          Stock = product.Stock,
                                          ManufPrice = product.crtManufacturerPrice,
                                          SellPrice = product.crtSellPrice,
                                      };

            binding.DataSource = queryProductsReturn.ToList();
            //MessageBox.Show("Duration: " + (DateTime.Now - startTime));
            return binding;
        }

    }

}
