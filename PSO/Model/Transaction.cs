﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO.Model
{
    public class Transaction
    {
        public int Id { get; set; }
        public int ClientId { get; set; }

        //public DateTime TransactionEnd { get; set; }
        public string TransactionStatus { get; set; }
        public decimal TotalCost { get; set; }
        public DateTime TransactionTime { get; set; }
        public Transaction()
        {
            TransactionStatus = "Started";
            TotalCost = 0;
            TransactionTime = DateTime.Now;
        }



        //public Client Client { get; set; }
        //public int ShoppingCartId { get; set; }
        //public ShoppingCart ShoppingCart { get; set; }

    }
}
