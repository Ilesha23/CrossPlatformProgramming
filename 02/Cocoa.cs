using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01
{
    public class Cocoa : ChocolateProduct
    {
        protected bool isWithMilk;
        protected double weight;
        public Cocoa()
        {
            Name = "Default";
            isLiquid = false;
            isWithMilk = false;
            weight = 0.0;
            Price = 0m;
        }
        public Cocoa(string name, bool liquid, bool milk, double w, decimal price)
        {
            Name = name;
            isLiquid = liquid;
            isWithMilk = milk;
            weight = w;
            Price = price;
        }
        public Cocoa(bool liquid, bool milk, double w)
        {
            isLiquid = liquid;
            isWithMilk = milk;
            weight = w;
        }
        public override string ToString()
        {
            string s = "Name: " + Name + "    Liquid: " + isLiquid + "    With milk: " + isWithMilk + "    Weight: " + weight + "(g)    Price: " + Price;
            return s;
        }
    }
}