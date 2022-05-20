using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Container<Product> c = new Container<Product>();
            c.Add(new Milk("dksajd", true, 12, 43, 23, 43));
            c.Add(new Milk("bfgdgg", true, 12, 43, 23, 43));
            c.Add(new Milk("asdasd", true, 12, 43, 23, 43));
            c.Sort();
            foreach (Product p in c)
                Console.WriteLine(p);

            /*LinkedList<Product> l = new LinkedList<Product>();
            l.Add(new Milk("dksajd", true, 12, 43, 23, 43));
            l.Add(new Milk("bfgdgg", true, 12, 43, 23, 43));
            l.Add(new Milk("asdasd", true, 12, 43, 23, 43));
            //Console.WriteLine(l[0].ToString());
            //l.Sort();
            foreach (Product p in l)//////////////////////////////////////////////////////////////////////
                Console.WriteLine(p);*/
        }
    }
}
