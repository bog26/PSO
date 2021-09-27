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

        public static BindingSource BindProductsToGrid()
        {
            psDBContext psContext = new psDBContext();

            BindingSource binding = new BindingSource();
            var queryProducts = from product in psContext.Products
                                select new
                                {
                                    Model = product.Model,
                                    Category = product.ProductSubCategoryId,
                                    Manufacturer = product.ManufacturerId,
                                    Stock = product.Stock,
                                    ManufPrice = product.crtManufacturerPrice,
                                    SellPrice = product.crtSellPrice,
                                };
            binding.DataSource = queryProducts.ToList();

            return binding;

        }
    }

}
