using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO.Model
{
    class Admin : IUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        private UserPersonalData adminPersonalData;

        public void CreateAdmin(string chosenName, UserPersonalData personalInfo)
        {
            UserName = chosenName;
            this.adminPersonalData = personalInfo;
        }
        //public string AdminPersonalData
    }
}
