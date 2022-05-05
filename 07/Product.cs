using System;

namespace _07
{
    public abstract class Product : IName, IName<Product>
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

        public int CompareTo(Product p)
        {
            return Name.CompareTo(p.Name);
        }

        public int CompareTo<T>(T data) where T : IName
        {
            return this.Name.CompareTo(data.Name);
        }

        public override string ToString()
        {
            string s = "Name: " + name + "    Price: " + price;
            return s;
        }
    }
}