﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string About { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool Discount { get; set; }
    }
}
