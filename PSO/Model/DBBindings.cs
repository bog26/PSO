using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


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
        public static BindingSource BindCrtUserAddressToGrid(string userName)
        {
            psDBContext psContext = new psDBContext();

            BindingSource binding = new BindingSource();
            var queryAdmin = from user in psContext.Admins
                        where user.UserName == userName
                        select new
                        /*
                        {
                            Street = user.UserInfo.Address.Street,
                            StreetNr = user.UserInfo.Address.StreetNr,
                            City = user.UserInfo.Address.City,
                            Region = user.UserInfo.Address.Region,
                            Country = user.UserInfo.Address.Country,
                            PostalCode = user.UserInfo.Address.PostalCode
                        };*/

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
                             /*
                             {
                                 Street = user.UserInfo.Address.Street,
                                 StreetNr = user.UserInfo.Address.StreetNr,
                                 City = user.UserInfo.Address.City,
                                 Region = user.UserInfo.Address.Region,
                                 Country = user.UserInfo.Address.Country,
                                 PostalCode = user.UserInfo.Address.PostalCode
                             };*/
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
    }
}
