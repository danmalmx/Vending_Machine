using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_19
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var price = rnd.Next(100, 1000);
            int[] wallet = { 100, 50, 20, 10, 5, 1 };
            int[] cash = new int[6];

            Console.WriteLine($"The price is {price}");
            Console.WriteLine();
            Console.Write("How much are you giving the cashier? ");

            int payment = int.Parse(Console.ReadLine());
            int result = Math.Abs(price - payment);

            int remain = result;
                 
            int restToCheck = remain;

            //noOfCoins will store the total number of coins used, no matter what type
            int totalNoOfCoins = 0;
                                 
            //noOfCoins will store the number of coins used for a particular coin type
            int noOfCoins = 0;

            //int divisionResult = 0;

            Console.WriteLine("You should receive: {0}\n", remain);
                                 
            //This loop will check what coin types are appropriate to use, starting from the biggest value coin type
            //and moving towards the lowest coin type

            for (int i = 0; i < wallet.Length; i++)
            {
                noOfCoins = 0;
                noOfCoins = restToCheck / wallet[i];
                
                //check to see if divisionResult generated a number bigger than 1. If it did, we can use tht type of coin

                if (noOfCoins >= 1)
                {
                    totalNoOfCoins += noOfCoins;
                    restToCheck = restToCheck - noOfCoins * wallet[i];
                    Console.WriteLine($"You'll get the following: {noOfCoins} coins of type {wallet[i]}");
                }
            }

            Console.WriteLine("Total number of coins used: {0}", totalNoOfCoins);
            Console.ReadKey();
        }
    }
}
