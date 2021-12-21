﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestBuyCRUDBestPractices
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }    

        public int CategoryId { get; set; }

        public double Price { get; set; }

        public int OnSale { get; set; }

        public string StockLevel { get; set; }


    }
}
