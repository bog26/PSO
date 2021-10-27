using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO.Model
{
    public class WishList
    {
        //[Key]
        //[Key, ForeignKey("Client")]
        public int Id { get; set; }
        //public int WishListId { get; set; }
        //public string ClientName { get; set; }
        //public int ClientId { get; set; }
        //[Required]
        //public Client Client { get; set; }

        public IList<Product> Products { get; set; }
        //public ICollection<Product> WishProducts { get; set; }
        //public IList<int> WishPIDs { get; set; } = new List<int>() { };
        public WishList()
        {
            
        }
        public WishList(string user)
        {
            //ClientName = user;
            //WishPIDs = new List<int>() { };
        }
    }
}
