using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09
{
    [Serializable]
    public abstract class MilkProduct : Product
    {
        protected bool isLiquid;
        protected int shelfLifeDays;
        protected double fattiness;

        protected MilkProduct() : base()
        {
            isLiquid = false;
            shelfLifeDays = 0;
        }
        protected MilkProduct(string name, decimal price, bool liquid, int shelfLife) : base(name, price)
        {
            isLiquid = liquid;
            shelfLifeDays = shelfLife;
        }

        public bool IsLiquid
        {
            get { return isLiquid; }
            set { isLiquid = value; }
        }

        public int ShelfLifeDays
        {
            get { return shelfLifeDays; }
            set { shelfLifeDays = value; }
        }

        public override string ToString()
        {
            string s = "Name: " + name + "    isLiquid: " + isLiquid + "    Price: " + price;
            return s;
        }
    }
}