using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01
{
    public class Chocolate : ChocolateProduct
    {
        protected bool isBlack;
        protected double CocoaPercent;
        protected double weight;
        public Chocolate()
        {
            Name = "Default";
            isLiquid = false;
            isBlack = true;
            CocoaPercent = 0.0;
            weight = 0.0;
            Price = 0m;
        }
        public Chocolate(string name, bool liquid, bool black, double cocoa, double w, decimal price)
        {
            Name = name;
            isLiquid = liquid;
            isBlack = black;
            CocoaPercent = cocoa;
            weight = w;
            Price = price;
        }
        public Chocolate(bool liquid, bool black, double cocoa, double w)
        {
            isLiquid = liquid;
            isBlack = black;
            CocoaPercent = cocoa;
            weight = w;
        }
        public override string ToString()
        {
            string s = "Name: " + Name + "    Liquid: " + isLiquid + "    Black: " + isBlack + "    Cocoa percent: " + CocoaPercent + "%    Weight: " + weight + "(g)    Price: " + Price;
            return s;
        }
    }
}