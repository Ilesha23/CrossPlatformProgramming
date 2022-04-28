using System;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Milk m1 = new Milk("milk1", true, 5, 1, 10, 20.0m);
            Milk m2 = new Milk("milk2", true, 5, 1, 10, 20.0m);
            Console.WriteLine("{0} compare to {1} equals {2}", m1.Name, m2.Name, m1.CompareTo(m2));

            Container cont = new Container();
            cont.Push(m2);
            cont.Push(m1);
            cont.Sort();
            Console.WriteLine(cont.ToString());
        }
    }
}
