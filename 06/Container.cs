using System;

namespace _06
{
    public class Container<T> where T : IName<T>
    {
        protected T[] arr;
        protected int length;
        protected bool isSorted;

        public Container()
        {
            length = 0;
            isSorted = false;
            arr = new T[0];
        }

        ~Container() { } 

        public T this[int index]
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
        public T this[string name]
        {
            get
            {
                for (int i = 0; i < length; i++)
                {
                    if (arr[i].Name == name)
                    {

                        return arr[i];
                    }
                }
                throw new MyException("no item");
            }
            set
            {
                for (int i = 0; i < length; i++)
                {
                    if (arr[i].Name == name)
                    {
                        arr[i] = value;
                    }
                }
            }
        }
        public void Add(T data)
        {
            T el = data;
            Resize(length + 1);
            arr[length++] = el;
            if (length > 1 && string.Compare(arr[length - 2].ToString(), arr[length - 1].ToString()) == 1)
                isSorted = false;
        }

        public void Pop(int index)
        {
            if (index >= 0 && index < length)
            {
                T[] temp = new T[length - 1];
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
            T[] temp = new T[index];
            for (int i = 0; i < length; i++)
            {
                temp[i] = arr[i];
            }
            arr = temp;
            temp = null;
        }

        public void Sort()
        {
            T temp = arr[0];
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (arr[i].CompareTo(arr[j]) > 0)
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
            string s = "Number of items: " + length + "\nIs sorted: " + isSorted + "\n";
            foreach (T item in arr)
            {
                s = s + item.ToString() + "\n";
            }
            return s;
        }
    }
}