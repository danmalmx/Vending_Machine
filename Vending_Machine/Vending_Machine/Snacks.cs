using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Snack : Products
    {

        public override void CreateProductGroup(Product ProductType, string Name, int Price, string Consuming)
        {
            ProductType = Product.Snack;
            this.Name = Name;
            this.Price = Price;
            this.Consuming = Consuming;            
        }
    }
}
