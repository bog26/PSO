﻿using System;
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
        public string Password { get; set; }
        public int UserPersonalDataId { get; set; }

        private UserPersonalData userInfo;
       public Admin()
        {

        }
        public UserPersonalData UserInfo { get; set; }
        public void CreateAdmin(string chosenName, UserPersonalData personalInfo)
        {
            UserName = chosenName;
            this.userInfo = personalInfo;
        }
        public override string ToString()
        {
            return UserName;
        }
        //public string AdminPersonalData
    }
}
