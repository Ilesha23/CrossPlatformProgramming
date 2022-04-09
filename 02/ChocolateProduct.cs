using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01
{
    public abstract class ChocolateProduct : Product
    {
        protected bool isLiquid;
        protected bool isSweet;
        public ChocolateProduct()
        {
            Name = "Default";
            Price = 0m;
            isLiquid = false;
            isSweet = false;
        }
        public ChocolateProduct(string name, decimal price, bool liquid, bool sweet)
        {
            Name = name;
            Price = price;
            isLiquid = liquid;
            isSweet = sweet;
        }
        public override string ToString()
        {
            string s = "Name: " + Name + "    isLiquid: " + isLiquid + "    Sweet: " + isSweet + "    Price: " + Price;
            return s;
        }
    }
}