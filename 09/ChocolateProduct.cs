using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09
{
    [Serializable]
    public abstract class ChocolateProduct : Product
    {
        protected bool isLiquid;
        protected bool isSweet;
        protected double weight;

        protected ChocolateProduct() : base()
        {
            isLiquid = false;
            isSweet = false;
        }
        protected ChocolateProduct(string name, decimal price, bool liquid, bool sweet) : base(name, price)
        {
            isLiquid = liquid;
            isSweet = sweet;
        }

        public bool IsSweet
        {
            get { return isSweet; }
            set { isSweet = value; }
        }

        public bool IsLiquid
        {
            get { return isLiquid; }
            set { isLiquid = value; }
        }

        public override string ToString()
        {
            string s = "Name: " + name + "    isLiquid: " + isLiquid + "    Sweet: " + isSweet + "    Price: " + price;
            return s;
        }
    }
}