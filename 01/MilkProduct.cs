using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01
{
    public abstract class MilkProduct : Product
    {
        protected bool isLiquid;
        protected int shelfLifeDays;
        public MilkProduct()
        {
            Name = "Default";
            Price = 0m;
            isLiquid = false;
        }
        public MilkProduct(string name, decimal price, bool liquid)
        {
            Name = name;
            Price = price;
            isLiquid = liquid;
        }
        public override string ToString()
        {
            string s = "Name: " + Name + "    isLiquid: " + isLiquid + "    Price: " + Price;
            return s;
        }
    }
}