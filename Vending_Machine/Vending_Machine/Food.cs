﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Food : Products
    {
        public override void CreateProductGroup(string Name, int Price)
        {
            ProductType = Product.Food;
            this.Name = Name;
            this.Price = Price;
            Consuming = "Chew it up";
        }
    }
}