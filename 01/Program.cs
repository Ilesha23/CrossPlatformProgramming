using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Milk milk = new Milk("Milk", true, 5, 1.0, 7, 30.0m);
            Console.WriteLine(milk.ToString());

            Cheese cheese = new Cheese("Cheese", false, 30, true, 50.0, 0.5, 100.0m);
            Console.WriteLine(cheese.ToString());

            Chocolate chocolate = new Chocolate("Choc", false, true, 50.0, 500, 20.0m);
            Console.WriteLine(chocolate.ToString());

            Cocoa cocoa = new Cocoa("Cocoa", false, true, 500, 30.0m);
            Console.WriteLine(cocoa.ToString());
        }
    }
}
