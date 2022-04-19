using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01
{
    public class Cocoa : ChocolateProduct
    {
        protected bool isWithMilk;
        public Cocoa() :base()
        {
            isWithMilk = false;
            weight = 0.0;
        }
        public Cocoa(string name, bool liquid, bool milk, bool sweet, double w, decimal price) :base(name, price, liquid, sweet)
        {
            isWithMilk = milk;
            weight = w;
        }

        public bool IsWithMilk
        {
            get { return isWithMilk; }
            set { isWithMilk = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public override string ToString()
        {
            string s = "Name: " + name + "    Liquid: " + isLiquid + "    With milk: " + isWithMilk + "    Weight: " + weight + "(g)    Price: " + price;
            return s;
        }
    }
}