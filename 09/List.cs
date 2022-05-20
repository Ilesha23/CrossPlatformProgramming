using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09
{
    public class Item<T>
    {
        public T Data { get; set; }
        public Item<T> Next { get; set; }
        public Item<T> Prev { get; set; }
        public Item(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
    public class LinkedList<T> : IEnumerable<Item<T>> where T : IName<T>
    {
        private Item<T> head = null;
        private Item<T> tail = null;
        private int count = 0;
        public int Count { get { return count; } }
        public void Add(T data)
        {
            Item<T> item = new Item<T>(data);
            if (head != null)
            {
                tail.Next = item;
                item.Prev = tail;
                tail = item;
            }
            else
            {
                head = tail = item;
                head.Prev = null;
            }
            count++;
        }

        public Item<T> this[int index]
        {
            get
            {
                if (index < 0 | index >= count)
                    throw new ArgumentOutOfRangeException();
                Item<T> item = head;
                for (int i = 0; i < index; i++)
                {
                    item = item.Next;
                }
                return item;
            }
        }

        public void Delete(int index)
        {
            Item<T> item = head;
            for (int i = 0; i < index; i++)
            {
                item = item.Next;
            }
            item.Prev.Next = item.Next;
            item.Next.Prev = item.Prev;
            count--;
        }

        /*public void Sort()
        {
            Item<T> item = new Item<T>(head.Data);
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (this[i].Data.CompareTo(this[j].Data) > 0)
                    {
                        item.Data = this[i].Data;
                        this[i].Data = this[j].Data;
                        this[j].Data = item.Data;
                    }
                }
            }
        }*/

        public override string ToString()
        {
            Item<T> temp = head;
            string s = "Number of items: " + count + "\n";
            for (int i = 0; i < count; i++)
            {
                s += temp.ToString() + "\n";
                temp = temp.Next;
            }
            return s;
        }

        public IEnumerator<Item<T>> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new LinkedListEnum<T>(this);
        }

        /*IEnumerator IEnumerable.GetEnumerator()
        {
            return new LinkedListEnum<T>(this);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerator();
        }*/
    }
}