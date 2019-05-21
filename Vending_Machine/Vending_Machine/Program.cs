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
            List<Products> productItems = new List<Products>();

            var snack = new Snack();
            var drink = new Beverages();
            var food = new Food();
            
            snack.CreateProductGroup("Chips", 25);
            drink.CreateProductGroup("Coca-Cola", 15);
            food.CreateProductGroup("Hamburger", 85);

            productItems.Add(snack);
            productItems.Add(drink);
            productItems.Add(food);


            Console.WriteLine("ID: \t Type: \t \t Name: \t Price: \t How to consume it:");
            Console.WriteLine();
            foreach (var item in productItems)
            {
            Console.WriteLine($"{++item.Id} \t {item.ProductType} \t \t {item.Name} \t  {item.Price} \t {item.Consuming}");
            }

            Console.ReadKey();
        }
    }
}
