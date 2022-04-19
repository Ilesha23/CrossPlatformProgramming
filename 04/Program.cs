using _02;
using _04;
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
            Cheese cheese = new Cheese("Cheese", false, 30, true, 50.0, 0.5, 100.0m);
            Chocolate chocolate = new Chocolate("Choc", false, true, true, 50.0, 500, 20.0m);
            Cocoa cocoa = new Cocoa("Cocoa", false, true, true, 500, 30.0m);

            Container c = new Container();
            c.push(milk);
            c.push(cheese);
            c.push(chocolate);
            c.push(cocoa);

            try
            {
                Console.WriteLine(c[-1].ToString());
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message + $": {e.Index}");
            }

            try
            {
                Console.WriteLine(c["Pencil"].ToString());
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message + $": {e.Name}");
            }

            try
            {
                Console.WriteLine(c[21.0m].ToString());
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message + $": {e.Price}");
            }
        }
    }
}

