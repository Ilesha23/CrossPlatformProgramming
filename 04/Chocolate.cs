using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01
{
    public class Chocolate : ChocolateProduct
    {
        protected bool isBlack;
        protected double cocoaPercent;
        public Chocolate() :base()
        {
            isBlack = true;
            cocoaPercent = 0.0;
            weight = 0.0;
        }
        public Chocolate(string name, bool liquid, bool black, bool sweet, double cocoa, double w, decimal price) :base(name, price, liquid, sweet)
        {
            isBlack = black;
            cocoaPercent = cocoa;
            weight = w;
        }

        public double CocoaPercent
        {
            get { return cocoaPercent; }
            set { cocoaPercent = value; }
        }

        public bool IsBlack
        {
            get { return isBlack; }
            set { isBlack = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public override string ToString()
        {
            string s = "Name: " + name + "    Liquid: " + isLiquid + "    Black: " + isBlack + "    Cocoa percent: " + cocoaPercent + "%    Weight: " + weight + "(g)    Price: " + price;
            return s;
        }
    }
}