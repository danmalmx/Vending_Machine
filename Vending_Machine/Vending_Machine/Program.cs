using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            var Id = 0;

            var snack1 = new Snack();

            snack1.CreateProductGroup("Chips", 25);

            Console.WriteLine("ID: \t Type: \t Name: \t Price: \t How to consume it:");
            Console.WriteLine();
            Console.WriteLine($"{++Id} \t {snack1.ProductType} \t {snack1.Name} \t {snack1.Price} \t {snack1.Consuming}");

            Console.ReadKey();
        }
    }
}
