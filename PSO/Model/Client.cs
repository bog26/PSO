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
        private UserPersonalData clientPersonalData;
        public void CreateClient(string chosenName, UserPersonalData personalInfo)
        {
            UserName = chosenName;
            this.clientPersonalData = personalInfo;
        }
        public override string ToString()
        {
            return UserName;
        }
    }
}
