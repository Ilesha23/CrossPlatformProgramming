using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01
{
    public class Cheese : MilkProduct
    {
        protected double fattiness;
        protected double weight;
        protected bool isSoft;
        public Cheese()
        {
            Name = "Default";
            isLiquid = false;
            shelfLifeDays = 0;
            isSoft = false;
            Price = 0m;
            fattiness = 0.0;
            weight = 0.0;
        }
        public Cheese(string name, bool liquid, int ShelfLife, bool soft, double fat, double w, decimal price)
        {
            Name = name;
            isLiquid = liquid;
            shelfLifeDays = ShelfLife;
            isSoft = soft;
            Price = price;
            fattiness = fat;
            weight = w;
        }
        public Cheese(bool liquid, int ShelfLife, bool soft, double fat, double w)
        {
            isLiquid = liquid;
            shelfLifeDays = ShelfLife;
            isSoft = soft;
            fattiness = fat;
            weight = w;
        }
        public override string ToString()
        {
            string s = "Name: " + Name + "    Soft: " + isSoft + "    Shelf life: " + shelfLifeDays + "day(s)    Fattiness: " + fattiness + "%    Weight: " + weight + "(Kg)    Price: " + Price;
            return s;
        }
    }
}