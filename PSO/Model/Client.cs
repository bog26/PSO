﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO.Model
{
    public class Client : IUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserPersonalDataId { get; set; }
        public int UserAddressId { get; set; }
        private UserPersonalData userInfo;
        private UserAddress userAddress;
        public Client()
        {

        }
        public UserPersonalData UserInfo { get; set; }
        public UserAddress UserAddress { get; set; }
        public void CreateClient(string chosenName, UserPersonalData personalInfo)
        {
            UserName = chosenName;
            this.userInfo = personalInfo;
        }
        public override string ToString()
        {
            return UserName;
        }
    }
}
