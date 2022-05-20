using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09
{
    public class LinkedListEnum<T> : IEnumerator<Item<T>> where T : IName<T>
    {
        private LinkedList<T> list;
        int position = -1;
        public LinkedListEnum(LinkedList<T> list)
        {
            this.list = list;
        }

        public Item<T> Current => list[position];

        object IEnumerator.Current => Current;

        /*public T Current => Current;

        object IEnumerator.Current => Current;*/

        /* public T Current
{
get
{
for (int i = 0; i < list.Count; i++)
{
if(i == position)
{
return ;
}
}
throw new InvalidOperationException();
}
}*/



        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            position++;
            return (position < list.Count);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}