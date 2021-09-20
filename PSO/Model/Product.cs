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
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Stock { get; set; }
        public List <decimal>  Prices { get; set; }

        public List<string> Reviews { get; set; }  //obj
        public Product()
        {

        }
        public void increasePrice()
        {

        }
        public void decreasePrice()
        {

        }
        

    }
}
