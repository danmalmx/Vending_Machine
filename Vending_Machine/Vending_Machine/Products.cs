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
            Beverage,
            Food
        }

        public int Id { get; set; }
        public Product ProductType { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Consuming { get; set; }

        public abstract void CreateProductGroup(string Name, int Price);

    }

}
