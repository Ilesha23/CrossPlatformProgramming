using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Milk m1 = new Milk("milk1", true, 5, 1, 4, 20);
            Milk m2 = new Milk("milk2", true, 4, 2, 9, 30.0m);

            LinkedList<Product> list = new LinkedList<Product>();
            list.Add(m2);
            list.Add(m1);
            list.Sort();
            Console.WriteLine(list.ToString());
            Console.WriteLine();

            Container<Product> cont = new Container<Product>();
            cont.Add(m2);
            cont.Add(m1);
            cont.Sort();
            Console.WriteLine(cont.ToString());
        }
    }
}
