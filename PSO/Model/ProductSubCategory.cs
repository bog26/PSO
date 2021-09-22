﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSO.Model
{
    public class ProductSubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductCategoryId { get; set; }
        ProductCategory Category { get; set; }

    }
}
