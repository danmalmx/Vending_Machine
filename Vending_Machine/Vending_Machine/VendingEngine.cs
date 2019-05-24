using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class VendingEngine 
    {
        //public Product ProductType { get; set; }
        public List<Products> Items { get; set; }
        int cashAmount = 0;
        int totalCost = 0;


        public void ViewItems()
        {
            int Id = 1;
            Items = new List<Products>();

            var snacks = new Snack();
            var drinks = new Beverage();
            var foods = new Food();

            string ConsumeIt(IConsumeItem consume)
            {
                return consume.ConsumeIt();
            }

            //ConsumeIt(snacks);
            //ConsumeIt(drinks);
            //ConsumeIt(foods);

            //Snack items
            Items.Add(new Snack("Crisps", 20, ConsumeIt(snacks)));
            Items.Add(new Snack("Cookie", 10, ConsumeIt(snacks)));
            Items.Add(new Snack("IceCream", 25, ConsumeIt(snacks)));

            //Drink items
            Items.Add(new Beverage("Coca-Cola", 15, ConsumeIt(drinks)));
            Items.Add(new Beverage("Fizzy Water", 10, ConsumeIt(drinks)));
            Items.Add(new Beverage("Coffee", 20, ConsumeIt(drinks)));

            //Food items
            Items.Add(new Food("Cheese Burger", 85, ConsumeIt(foods)));
            Items.Add(new Food("Sandwhich", 60, ConsumeIt(foods)));
            Items.Add(new Food("Hot Dog", 35, ConsumeIt(foods)));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ID: \t Type: \t Name: \t \t Cost:");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var i in Items)
            {
                Console.WriteLine($"{Id++} \t {i.ProductType} \t {i.Name} \t {i.Price}");
            }
            Console.WriteLine();
        }

        public int InputCash()
        {
            while (true)
            {
                Console.Write("Enter cash, end with 0: ");
                int cashIn = int.Parse(Console.ReadLine());

                if (cashIn == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have loaded {cashAmount} into the machine");
                    Console.WriteLine();
                    break;
                }

                else if(cashIn % 10 != 0)
                {
                    Console.WriteLine("Only integer numbers with a 10 increase ");
                    continue;
                }
                cashAmount += cashIn;
            }
            return cashAmount;
        }

        public int ChooseItem()
        {
            // List of chosen items
            List<string> itemNames = new List<string>();
            List<string> consumeWay = new List<string>();

            while (true)
            {
                Console.Write("Choose an item, end with 0: ");
                int itemChoice = int.Parse(Console.ReadLine());

                if (itemChoice == 0)
                {
                    Console.WriteLine($"Total cost is {totalCost}");
                    break;
                }

                //Adds item cost to total cost
                totalCost += Items[itemChoice-1].Price;
                //Adds item name to list
                itemNames.Add(Items[itemChoice-1].Name);
                //Adds consume style to list
                consumeWay.Add(Items[itemChoice - 1].Consume);

            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"You have bought: ");
            Console.ForegroundColor = ConsoleColor.Gray;

            foreach (var item in itemNames.Zip(consumeWay, (a, b) => new { A = a, B = b }))
            {
                var a = item.A;
                var b = item.B;

                Console.WriteLine($"{a} which you consume by {b}");
              }

            Console.WriteLine();
                
                return totalCost;
        }

        public void CashRemain()
        {
            Console.WriteLine();
            int cashRemain = cashAmount - totalCost;
            Console.WriteLine($"You still have {cashRemain}");
            Console.ReadKey();
        }

        public void StartProgram()
        {
            ViewItems();
            InputCash();
            ChooseItem();
            CashRemain();            
        }

               
        }
}
