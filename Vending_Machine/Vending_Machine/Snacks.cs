﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Snack : Products
    {


        public override void CreateProductGroup(string Name, int Price)
        {
            ProductType = Product.Snack;
            this.Name = Name;
            this.Price = Price;
            Consuming = "Munch on it";            
        }
    }
}
