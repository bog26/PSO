using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO.Model
{
    class Client : IUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}
