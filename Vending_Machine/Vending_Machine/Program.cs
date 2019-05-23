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
            int Id = 0;
            List<Products> items = new List<Products>();

            var snacks = new Snack();
            var drinks = new Beverage();
            var foods = new Food();


            //ConsumeIt(snacks);
            //ConsumeIt(drinks);
            //ConsumeIt(foods);


            //Snack items
            items.Add(new Snack("Crisps", 20));
            items.Add(new Snack("Cookie", 10));
            items.Add(new Snack("IceCream", 25));


            //Drink items
            items.Add(new Beverage("Coca-Cola", 15));
            items.Add(new Beverage("Fizzy Water", 10));
            items.Add(new Beverage("Coffee", 20));

            //Food items
            items.Add(new Food("Cheese Burger", 85));
            items.Add(new Food("Sandwhich", 60));
            items.Add(new Food("Hot Dog", 35));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ID: \t Type: \t Name: \t \t Cost:");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var i in items)
            {
                Console.WriteLine($"{++Id} \t {i.ProductType} \t {i.Name} \t {i.Price}");
            }
        Console.ReadKey();
        }

        //Trial of a polymorphic method

        static void ConsumeIt(IConsumeItem consume)
        {
            consume.ConsumeIt();
        }
    }
}
