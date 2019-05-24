using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Beverage : Products, IConsumeItem
    {
        public Beverage()
        {
        }

        public Beverage(string Name, int Price, string consume)
        {
            ProductType = Product.Drink;
            this.Name = Name;
            this.Price = Price;
            Consume = consume;
        }

        public string ConsumeIt()
        {
            return "sipping it down!";
        }
    }
}
