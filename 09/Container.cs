using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace _09
{
    [Serializable]
    public class Container<T> : IEnumerable<T> where T : IName<T>
    {
        T[] arr;
        protected static int length;
        protected bool isSorted;

        public Container()
        {
            length = 0;
            isSorted = false;
            arr = new T[0];
        }

        ~Container() { } 

        public int Length
        {
            get { return length; }
        }

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
                    if (name.CompareTo(arr[i]) == 0)
                        return arr[i];
                throw new MyException("There is no product with this name: ", name);
            }
            set
            {
                for (int i = 0; i < length; i++)
                    if (arr[i].Name == name)
                        arr[i] = value;
                throw new MyException("There is no product with this name: ", name);
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

        public void PopAll()
        {
            arr = null;
            length = 0;
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
                    if (arr[i].CompareTo(arr[j])/*arr[i].Data.CompareTo(arr[j].Data)*/ > 0)
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

        public IEnumerator<T> GetEnumerator()
        {
            //return new ContainerEnum<T>(this);
            for (int i = 0; i < length; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Ser()
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("file.bin", FileMode.Create))
            {
                formatter.Serialize(stream, arr);
            }
        }

        public void Des()
        {
            IFormatter formatter = new BinaryFormatter();
            using (Stream stream = new FileStream("file.bin", FileMode.Open))
            {
                arr = (T[])formatter.Deserialize(stream);
            }
            length = arr.GetUpperBound(0) + 1;
        }
    }
}