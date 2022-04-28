using System;

namespace _05
{
    public abstract class Product : IName
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

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            Product p = obj as Product;
            if (p != null)
                return Name.CompareTo(p.Name);
            else
                throw new MyException("Object is not a Product");
        }

        public override string ToString()
        {
            string s = "Name: " + name + "    Price: " + price;
            return s;
        }
    }
}