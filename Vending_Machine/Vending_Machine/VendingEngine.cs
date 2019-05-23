using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class VendingEngine : Products
    {
        public Product ProductType { get; set; }
        
        public void InputCash()
        {
            int cashAmount = 0;

            while (true)
            {
                Console.Write("Enter cash, end with 0: ");
                int cashIn = int.Parse(Console.ReadLine());

                if (cashIn == 0)
                {

                }
                cashAmount += cashIn;
            }
        }

        }
    }
}
