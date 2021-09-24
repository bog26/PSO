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
            UserPersonalData pdata;

            if (InternalDBQueries.CheckForAdminRights(loggedUser))
            {
                var crtUser = psContext.Admins.First(x => x.UserName == loggedUser);
                pdata = psContext.UserPersonalDatas.Find(crtUser.UserPersonalDataId); 
                //pdata = psContext.UserPersonalDatas.Find(crtUser.UserInfo.Id); //not ok
                

            }
            else 
            {
                var crtUser = psContext.Clients.First(x => x.UserName == loggedUser);
                pdata = psContext.UserPersonalDatas.Find(crtUser.UserPersonalDataId);
            }
            UserPDataChange(pdata, choice, input);
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
            UserAddress personalAddr;
            if (InternalDBQueries.CheckForAdminRights(loggedUser))
            {
                var crtUser = psContext.Admins.First(x => x.UserName == loggedUser);
                personalAddr = psContext.UserAddresses.Find(crtUser.UserAddressId);
            }
            else
            {
                var crtUser = psContext.Clients.First(x => x.UserName == loggedUser);
                personalAddr = psContext.UserAddresses.Find(crtUser.UserAddressId);
            }
            UserAddressChange(personalAddr, choice, input);
            psContext.SaveChanges();
        }

        public static void UserAddressChange(UserAddress userAddress, string choice, string change)
        {
            switch (choice)
            {
                case "Street":
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

        public static void CreateNewCategory(string category)
        {
            var psContext = new psDBContext();
            var existingCategories = psContext.ProductCategories.Where(x => x.Name == category).ToList();
            if(existingCategories.Count==0)
            {
                var newCategory = new ProductCategory();
                newCategory.Name = category;
                psContext.ProductCategories.Add(newCategory);
            }

            psContext.SaveChanges();
        }

        public static void CreateNewManufacturer(string manufacturer)
        {
            var psContext = new psDBContext();
            var existingManufacturers = psContext.Manufacturers.Where(x => x.Name == manufacturer).ToList();
            if (existingManufacturers.Count == 0)
            {
                var newManufacturer = new Manufacturer();
                newManufacturer.Name = manufacturer;
                psContext.Manufacturers.Add(newManufacturer);
            }

            psContext.SaveChanges();
        }

        public static void CreateNewSubCategory(string subCategory, string category)
        {
            var psContext = new psDBContext();
            var Category = psContext.ProductCategories.First(x => x.Name == category);
            var existingSubCategories = psContext.ProductSubCategories.Where(x => x.Name == subCategory).ToList();
            if (existingSubCategories.Count == 0)
            {
                var newSubCategory = new ProductSubCategory();
                newSubCategory.Name = subCategory;
                newSubCategory.ProductCategoryId = Category.Id;
                //var prodCategory = psContext.ProductCategories.Find(newSubCategory.ProductCategoryId);
                psContext.ProductSubCategories.Add(newSubCategory);
            }

            psContext.SaveChanges();
        }

        public static void CreateNewProduct(string[] productProperties, int initStock, decimal[] prices)
        {
            var psContext = new psDBContext();
            string productName = productProperties[0];
            string productModel = productProperties[1];
            string productManufacturer = productProperties[2];
            string productSubcategory = productProperties[3];
            decimal sellPrice = prices[0];
            decimal supplierPrice = prices[1];
            var Manufacturer = psContext.Manufacturers.First(x => x.Name == productManufacturer);
            var Subcategory = psContext.ProductSubCategories.First(x => x.Name == productSubcategory);

            //check for existing productName
            var existingProductName = psContext.Products.Where(x => x.ProductName == productName).ToList();
            if(existingProductName.Count == 0)
            {
                var newProduct = new Product();
                newProduct.ProductName = productName;
                newProduct.Model = productModel;
                newProduct.ManufacturerId = Manufacturer.Id;
                newProduct.ProductSubCategoryId = Subcategory.Id;
                newProduct.Stock = initStock;
                newProduct.crtSellPrice = sellPrice;
                newProduct.crtManufacturerPrice = supplierPrice;
                psContext.Products.Add(newProduct);
            }

            psContext.SaveChanges();
        }



    }
}
