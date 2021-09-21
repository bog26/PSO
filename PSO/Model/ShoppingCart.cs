using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO.Model
{
    public class ShoppingCart
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        private Dictionary<Product, int> cartItems;
        public decimal ShoppingCartCalculation()
        {
            decimal cost = 0;
            foreach(KeyValuePair<Product, int> pair in this.cartItems)
            {
                cost += pair.Key.crtClientPrice * pair.Value;
            }
            return cost;
        }
        
    }
}
