using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01
{
    public abstract class Product
    {
        protected string Name;
        protected decimal Price;
        public Product()
        {
            Name = "Default";
            Price = 0m;
        }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            string s = "Name: " + Name + "    Price: " + Price;
            return s;
        }

        public string getName()
        {
            return Name;
        }
        public void setName(string name)
        {
            this.Name = name;
        }

        public decimal getPrice()
        {
            return Price;
        }
        public void setPrice(decimal price)
        {
            this.Price = price;
        }
    }
}