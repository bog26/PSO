using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int ProductSubCategoryId { get; set; }
        ProductSubCategory SubCategory { get; set; }
        public int ManufacturerId { get; set; }
        Manufacturer Manufacturer { get; set; }

        public string Model { get; set; }

        public int Stock { get; set; }
        //public List <decimal>  Prices { get; set; }
        public decimal crtSellPrice { get; set; }

        public decimal crtManufacturerPrice { get; set; }
        public List<string> Reviews { get; set; }  //obj
        public Product()
        {

        }
        public void increaseSellPrice(decimal priceIncrease)
        {

        }
        public void decreaseSellPrice(decimal priceDecrease)
        {

        }
        public void increaseStock(int nrOfProducts)
        {
            Stock += nrOfProducts;
        }
        public void decreaseStock(int nrOfProducts)
        {
            Stock -= nrOfProducts;
        }


    }
}
