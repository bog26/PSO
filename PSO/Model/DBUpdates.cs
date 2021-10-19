using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


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
                    if (UserInputCheck.CheckName(change))
                    {
                        userData.FirstName = change;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong name");
                    }
                    break;
                case "LastName":
                    if (UserInputCheck.CheckName(change))
                    {
                        userData.LastName = change;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong name");
                    }
                    break;
                case "email":
                    if (UserInputCheck.CheckEmailAddress(change))
                    {
                        userData.Email = change;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong email address");
                    }

                    break;
                case "Telephone":
                    if (UserInputCheck.CheckNumber(change))
                    {
                        userData.Telephone = change;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong number");
                    }
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
                    if (UserInputCheck.CheckMultiName(change))
                    {
                        userAddress.Street = change;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong street name");
                    }

                    break;
                case "StreetNr":
                    int address;
                    if (int.TryParse(change, out address))
                    {
                        userAddress.StreetNr = address;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong input!");
                    }
                    break;
                case "City":
                    if (UserInputCheck.CheckMultiName(change))
                    {
                        userAddress.City = change;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong city name");
                    }
                    break;
                case "Region":
                    if (UserInputCheck.CheckMultiName(change))
                    {
                        userAddress.Region = change;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong region name");
                    }
                    break;
                case "Country":
                    if (UserInputCheck.CheckMultiName(change))
                    {
                        userAddress.Country = change;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong country name");
                    }
                    break;
                case "PostalCode":
                    int code;
                    if (int.TryParse(change, out code))
                    {
                        userAddress.PostalCode = code;
                        MessageBox.Show(choice + ": " + change);
                    }
                    else
                    {
                        MessageBox.Show("wrong input!");
                    }
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
            if (existingCategories.Count == 0)
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
            if (existingProductName.Count == 0)
            {
                var newProduct = new Product();
                newProduct.ProductName = productName;
                newProduct.Model = productModel;
                newProduct.ManufacturerId = Manufacturer.Id;
                newProduct.SubCategory = Subcategory;
                //newProduct.ProductSubCategoryId = Subcategory.Id;
                newProduct.Stock = initStock;
                newProduct.crtSellPrice = sellPrice;
                newProduct.crtManufacturerPrice = supplierPrice;
                newProduct.Manufacturer = Manufacturer;
                psContext.Products.Add(newProduct);

            }

            psContext.SaveChanges();
        }

        public static bool DataGridViewAllowCustomExtraction(int cellIndex, int[] allowedColumnIndexes)
        {
            bool cellDataExtractionAllowed = false;
            foreach (int allowedIndex in allowedColumnIndexes)
            {
                if (cellIndex == allowedIndex)
                {
                    cellDataExtractionAllowed = true;
                }
            }

            return cellDataExtractionAllowed;
        }

        public static bool WriteProductDataToDB(int productId, int column, string value)
        {
            bool writeToDBSuccessful = false;
            var psContext = new psDBContext();
            var crtProd = psContext.Products.Find(productId);

            if (column == 1)
            {
                crtProd.ProductName = value;
                writeToDBSuccessful = true;
            }
            else if (column == 6)
            {
                if (int.TryParse(value, out int stock) && stock >= 0)
                {
                    crtProd.Stock = stock;
                    writeToDBSuccessful = true;
                }
            }
            else if (column == 7)
            {
                if (decimal.TryParse(value, out decimal manufPrice) && manufPrice >= 0)
                {
                    crtProd.crtManufacturerPrice = manufPrice;
                    writeToDBSuccessful = true;
                }
            }
            else if (column == 8)
            {
                if (decimal.TryParse(value, out decimal sellPrice) && sellPrice >= 0)
                {
                    crtProd.crtSellPrice = sellPrice;
                    writeToDBSuccessful = true;
                }
            }
            psContext.SaveChanges();
            return writeToDBSuccessful;
        }

        public static bool WriteMessageToDB(Message newMessage)
        {
            bool writeToDBSuccessful = false;
            if(InternalDBQueries.CheckForExistingUser(newMessage.Receiver))
            {
                var psContext = new psDBContext();
                psContext.Messages.Add(newMessage);
                psContext.SaveChanges();
                writeToDBSuccessful = true;
            }
            return writeToDBSuccessful;
        }
        public static string GetMessage(string user, int messageIndex)
        {
            psDBContext psContext = new psDBContext();
            var queryReceivedMessages = from message in psContext.Messages
                                        //where message.Receiver == user 
                                        where message.Receiver == user 
                                            && message.MessageStatus != "deleted"
                                        select message.MessageBody;
            string messageToDisplay = queryReceivedMessages.ToList()[messageIndex];
            return messageToDisplay;
        }
        public static string GetMessage(string user, int messageIndex, string searchWord)
        {
            psDBContext psContext = new psDBContext();
            var queryReceivedMessages = from message in psContext.Messages
                                            
                                        where message.Receiver == user 
                                            && message.MessageStatus != "deleted"
                                            && message.MessageBody.Contains(searchWord)
                                        select message.MessageBody;
            string messageToDisplay = queryReceivedMessages.ToList()[messageIndex];
            return messageToDisplay;
        }
        public static List<string> GetMessages(string user)
        {
            psDBContext psContext = new psDBContext();
            var queryReceivedMessages = from message in psContext.Messages
                                        where message.Receiver == user
                                        select message.MessageBody;
            List<string> messages = queryReceivedMessages.ToList();
            return messages;
        }
        public static bool IsMessageEncrypted(string user, int messageIndex)
        {
            bool messageEncryption = false;
            psDBContext psContext = new psDBContext();
            var queryReceivedMessages = from message in psContext.Messages
                                        //where message.Receiver == user
                                        where message.Receiver == user &&
                                              message.MessageStatus != "deleted"
                                        select message.IsEncrypted;

            messageEncryption = queryReceivedMessages.ToList()[messageIndex];
            
           
            return messageEncryption;
        }
        public static bool IsMessageEncrypted(string user, int messageIndex, string searchWord)
        {
            bool messageEncryption = false;
            psDBContext psContext = new psDBContext();
            var queryReceivedMessages = from message in psContext.Messages
                                            //where message.Receiver == user
                                        where message.Receiver == user &&
                                              message.MessageStatus != "deleted" &&
                                              message.MessageBody.Contains(searchWord)
                                        select message.IsEncrypted;

            messageEncryption = queryReceivedMessages.ToList()[messageIndex];


            return messageEncryption;
        }

        public static void DeleteMsg(string user, int messageIndex)
        {
            psDBContext psContext = new psDBContext();
            var messages = psContext.Messages.Where(x => (x.Receiver == user)
                                                        &&((x.MessageStatus=="sent")||(x.MessageStatus == "read")));
            var messageToDelete = messages.ToList()[messageIndex];
            messageToDelete.DeleteMessage();
            psContext.SaveChanges();
        }
        public static void SpamMsg(string user, int messageIndex)
        {
            psDBContext psContext = new psDBContext();
            var messages = psContext.Messages.Where(x => (x.Receiver == user) 
                                                     && (   (x.MessageStatus == "sent")
                                                        ||  (x.MessageStatus == "read")) );
            var messageToSpam = messages.ToList()[messageIndex];
            messageToSpam.SpamMessage();
            psContext.SaveChanges();
        }
        public static void ReadMsg(string user, int messageIndex)
        {
            psDBContext psContext = new psDBContext();
            var messages = psContext.Messages.Where(x => (x.Receiver == user)
                                                     && (  (x.MessageStatus == "sent") 
                                                        || (x.MessageStatus == "read")) );
            var messageToRead = messages.ToList()[messageIndex];
            messageToRead.ReadMessage();
            psContext.SaveChanges();
        }



    }
}
