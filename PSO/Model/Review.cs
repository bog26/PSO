﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO.Model
{
    public class Review
    {
        public int Id { get; set; }
        public int ReviewMark { get; set; }
        public string ReviewText { get; set; }
        public int ClientId { get; set; }
        public int ProductId { get; set; }
        public Client Client { get; set; }

        public Product Product { get; set; }
    }
}
