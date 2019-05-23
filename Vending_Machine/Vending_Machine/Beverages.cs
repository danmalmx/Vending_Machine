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

        public Beverage(string Name, int Price)
        {
            ProductType = Product.Drink;
            this.Name = Name;
            this.Price = Price;
        }

        public void ConsumeIt()
        {
            Console.WriteLine("Sip it down");
        }
    }
}
