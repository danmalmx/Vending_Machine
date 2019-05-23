using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Food : Products, IConsumeItem
    {
        public Food()
        {
        }

        public Food(string Name, int Price)
        {
            ProductType = Product.Food;
            this.Name = Name;
            this.Price = Price;
        }

        public void ConsumeIt()
        {
            Console.WriteLine("Chew it up");
        }

    }
}
