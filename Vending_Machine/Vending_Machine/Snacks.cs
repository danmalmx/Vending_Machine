using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Snack : Products, IConsumeItem
    {
        public Snack()
        {
        }

        public Snack(string Name, int Price, string consume)
        {
            ProductType = Product.Snack;
            this.Name = Name;
            this.Price = Price;
            Consume = consume;
        }

        public string ConsumeIt()
        {
            return "munching on it!";
        }
    }
}
