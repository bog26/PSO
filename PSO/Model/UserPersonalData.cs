using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO.Model
{
    public class UserPersonalData
    {
        public int Id { get; set; }
        private string firstName;
        private string lastName;
        private DateTime birthDate;
        private string email;
        private string telephone;
        private UserAddress address;
        public UserPersonalData()
        {

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public UserAddress Address { get; set; }

    }
}
