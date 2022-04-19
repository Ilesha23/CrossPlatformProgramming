using _01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02
{
    public class Container
    {
        protected Product[] arr;
        protected int length;
        protected bool isSorted;

        public Container()
        {
            length = 0;
            isSorted = false;
            arr = new Product[0];
        }

        ~Container()
        {
            length = 0;
            arr = null;
        }

        /// <summary>Add element to back</summary>
        public void push(Product product)
        {
            Resize(length + 1);
            arr[length++] = product;
            if (length > 1 && string.Compare(arr[length - 2].getName(), arr[length - 1].getName()) == 1)
            {
                isSorted = false;
            }
        }

        /// <summary>Delete element by index</summary>
        public void pop(int index)
        {
            if (index >= 0 && index < length)
            {
                Product[] temp = new Product[length - 1];
                for (int i = 0; i < length; i++)
                {
                    if (i < index)
                    {
                        temp[i] = arr[i];
                    }
                    else if (i > index)
                    {
                        temp[i - 1] = arr[i];
                    }
                }
                arr = temp;
                temp = null;
            }
        }

        private void Resize(int index)
        {
            Product[] temp = new Product[index];
            for (int i = 0; i < length; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
            temp = null;
        }

        /// <summary>Sort by Name</summary>
        public void sort()
        {
            Product temp = arr[0];
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (string.Compare(arr[i].getName(), arr[j].getName()) == 1)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            isSorted = true;
        }
        /// <summary>get price of all container</summary>
        public decimal PriceOfAll()
        {
            decimal price = 0.0m;
            foreach (Product item in arr)
            {
                price += item.getPrice();
            }
            return price;
        }

        public override string ToString()
        {
            string s = "Number of products: " + length + "\nIs sorted: " + isSorted + "\nPrice of all products: " + PriceOfAll() + "\n";
            foreach (Product item in arr)
            {
                s = s + item.ToString() + "\n";
            }
            return s;
        }
    }
}