﻿using System;

namespace _06
{
    public class Elem<T>
    {
        public T Data { get; set; }
        public Elem(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
    public class Container<T>
    {
        protected Elem<T>[] arr;
        protected int length;
        protected bool isSorted;

        public Container()
        {
            length = 0;
            isSorted = false;
            arr = new Elem<T>[0];
        }

        ~Container()
        {
            length = 0;
            arr = null;
        }

        /// <summary>get/set element by index</summary>
        public Elem<T> this[int index]
        {
            get
            {
                if (index < 0 || index >= length)
                    throw new MyException("index is out of range", index);
                return arr[index];
            }
            set
            {
                if (index < 0 || index >= length)
                    throw new MyException("index is out of range", index);
                arr[index] = value;
            }
        }
        /// <summary>Add element to back</summary>
        public void Push(T data)
        {
            Elem<T> el = new Elem<T>(data);
            Resize(length + 1);
            arr[length++] = el;
            if (length > 1 && string.Compare(arr[length - 2].ToString(), arr[length - 1].ToString()) == 1)
            {
                isSorted = false;
            }
        }

        /// <summary>Delete element by index</summary>
        public void Pop(int index)
        {
            if (index >= 0 && index < length)
            {
                Elem<T>[] temp = new Elem<T>[length - 1];
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
            Elem<T>[] temp = new Elem<T>[index];
            for (int i = 0; i < length; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
            temp = null;
        }

        /// <summary>Sort by Name</summary>
        public void Sort()
        {
            Elem<T>temp = arr[0];
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i].ToString().CompareTo(arr[j]) == 1)
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            isSorted = true;
        }

        public override string ToString()
        {
            string s = "Number of products: " + length + "\nIs sorted: " + isSorted + "\n";
            foreach (Elem<T> item in arr)
            {
                s = s + item.ToString() + "\n";
            }
            return s;
        }
    }
}