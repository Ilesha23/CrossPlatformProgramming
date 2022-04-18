using _01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Container container = new Container();

            container.push(new Milk("Milk1", true, 4, 3, 5, 25.0m));
            container.push(new Milk("Milk2", true, 5, 1, 10, 30.0m));
            container.push(new Cheese("Cheese1", true, 25, false, 40, 400, 90.0m));
            container.push(new Cheese("Cheese2", false, 30, true, 50, 500, 100.0m));
            container.push(new Chocolate("Choc1", true, false, 45, 100, 30.0m));
            container.push(new Chocolate("Choc2", false, true, 50, 200, 25.0m));
            container.push(new Cocoa("Cocoa1", true, true, 90, 30.0m));
            container.push(new Cocoa("Cocoa2", false, false, 100, 40.0m));

            Console.WriteLine(container[0].ToString());
            Console.WriteLine(container["Cheese1"].ToString());
            Console.WriteLine(container[25.0m].ToString());

            //Console.WriteLine(container.ToString());
        }
    }
}
