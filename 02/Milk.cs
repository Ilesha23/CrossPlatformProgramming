using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01
{
    public class Milk : MilkProduct
    {
        protected double fattiness;
        protected double volume;
        public Milk()
        {
            Name = "Default";
            isLiquid = true;
            Price = 0m;
            fattiness = 0.0;
            volume = 0.0;
            shelfLifeDays= 0;
        }
        public Milk(string name, bool liquid, double fat, double vol, int shelfLife, decimal price)
        {
            Name = name;
            isLiquid = liquid;
            Price = price;
            fattiness = fat;
            volume = vol;
            shelfLifeDays = shelfLife;
        }
        public Milk(bool liquid, double fat, double vol, int shelfLife)
        {
            isLiquid = liquid;
            fattiness = fat;
            volume = vol;
            shelfLifeDays = shelfLife;
        }
        public override string ToString()
        {
            string s = "Name: " + Name + "\tLiquid: " + isLiquid + "\tFattiness: " + fattiness + "%\tVolume: " + volume + "(L)\tShelf Life: " + shelfLifeDays + " day(s)\tPrice: " + Price;
            return s;
        }
    }
}