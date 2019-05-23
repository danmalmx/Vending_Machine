using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    abstract class Products
    {
        public enum Product
        {
            Snack,
            Drink,
            Food
        }

        public Product ProductType { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

    }

}
