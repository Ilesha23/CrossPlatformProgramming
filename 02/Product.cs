using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01
{
    public abstract class Product
    {
        protected string name;
        protected decimal price;
        public Product()
        {
            name = "Default";
            price = 0m;
        }
        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public string Name
        {
            get { return name; }
            set{ name = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            string s = "Name: " + name + "    Price: " + price;
            return s;
        }
    }
}