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

            ve.StartProgram();
            //ve.ViewItems();
            //ve.ChooseItem();
            //ve.InputCash();
            
            Console.ReadKey();
        }

        //Trial of a polymorphic method

        //static void ConsumeIt(IConsumeItem consume)
        //{
        //    consume.ConsumeIt();
        //}
    }
}
