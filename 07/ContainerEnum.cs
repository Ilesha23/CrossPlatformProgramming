using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07
{
    public class ContainerEnum<T> : IEnumerator<T> where T : IName<T>
    {
        private Container<T> ts;
        int position = -1;

        public ContainerEnum(Container<T> ts)
        {
            this.ts = ts;
        }

        public T Current => ts[position];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            position++;
            return (position < ts.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}