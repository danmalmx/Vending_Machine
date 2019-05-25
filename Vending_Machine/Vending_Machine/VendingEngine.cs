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
        public int cashRemain;


        public void ViewItems()
        {
            int Id = 1;
            Items = new List<Products>();

            var snacks = new Snack();
            var drinks = new Beverage();
            var foods = new Food();

            //Calling on interface method 
            string ConsumeIt(IConsumeItem consume)
            {
                return consume.ConsumeIt();
            }

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
            var cashIn = 0;


            while (true)
            {
            ViewItems();
                try
                {
                Console.Write("Enter cash (in increments of 5), end with 0: ");
                cashIn = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();

                    continue;
                }

                if (cashIn == 0)
                {
                    Console.Clear();
                    ViewItems();
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write($"You have loaded {cashAmount} kr into the machine");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();
                    HandleItem();
                    break;
                }

                else if (cashIn % 5 != 0)
                {
                    Console.WriteLine("Only integer numbers with a 5 increase ");
                    continue;
                }

                cashAmount += cashIn;
                Console.Clear();
            }
            return cashAmount;
        }
        public void CashRemain()
        {
            cashRemain = cashAmount;
            int[] cash = new int[5];
            int[] wallet = { 100, 50, 20, 10, 5 };

            int noCoins = 0;
            int totalCoins = 0;

            Console.WriteLine();          
            if (cashRemain > 0)
            {                
                Console.WriteLine($"You get {cashAmount} kr in return, in the follwing values: ");
                for (int i = 0; i < cash.Length; i++)
                {
                    noCoins = cashRemain / wallet[i];

                    if (noCoins >= 1)
                    {
                        cash[i] += noCoins;
                        totalCoins += cash[i];
                        cashRemain = cashRemain % (cash[i] * wallet[i]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"{noCoins} x {wallet[i]}kr");
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }
            }
            else if (cashRemain < totalCost)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("You need to get more money");
            }
            else if (cashRemain > totalCost)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Come back when you have more money, bum!");
            }
        }               

        public int HandleItem()
        {
            // List of chosen items
            List<string> itemNames = new List<string>();
            // List of how to consume the item.
            List<string> consumeWay = new List<string>();
            int itemChoice = 0;

            while (true)
            {

                try
                {
                Console.WriteLine();
                Console.Write("Choose an item, end with 0: ");
                itemChoice = int.Parse(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine();

                    continue;
                }

                if (itemChoice == 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine($"Total cost is {totalCost}");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                }

                //Calculates costs and remaining cash
                cashRemain = cashAmount;
                totalCost += Items[itemChoice - 1].Price;
                cashAmount -= Items[itemChoice-1].Price;

                //Adds item name to list
                itemNames.Add(Items[itemChoice-1].Name);

                if (cashAmount < 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You're missing {Math.Abs(cashAmount)} for that {Items[itemChoice - 1].Name}, you bum!");
                    break;
                } 
                
                //Adds consume style to list
                consumeWay.Add(Items[itemChoice - 1].Consume);

                //Writes out remaining amount on a new line.
                Console.Clear();
                ViewItems();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"You still have {cashAmount} kr");
                Console.ForegroundColor = ConsoleColor.Gray;            
            }

                //List the items bought
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"You bought: ");
                Console.ForegroundColor = ConsoleColor.Gray;

                // Foreach loop for 2 variables - thank you stackoverflow.com!
                foreach (var item in itemNames.Zip(consumeWay, (a, b) => new { A = a, B = b }))
                {
                    var a = item.A;
                    var b = item.B;

                    Console.WriteLine($"{a} which you consume by {b}");
                }
            CashRemain();

            return cashAmount;
        }
    }
}