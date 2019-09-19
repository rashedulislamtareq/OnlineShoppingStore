﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShoppingStore.Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Category { get; set; } 
    }
}
