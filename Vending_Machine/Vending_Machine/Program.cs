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
            var ve = new VendingEngine();

            ve.InputCash();
            Console.ReadKey();
        }

    }
}
