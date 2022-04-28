using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05
{
    public class MyException : Exception
    {
        public int Index { get; }
        public string Name { get; }
        public decimal Price{ get; }
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception inner) : base(message, inner) { }
        public MyException(string message, int index) : base(message)
        {
            Index = index;
        }
        public MyException(string message, string name) : base(message)
        {
            Name = name;
        }
        public MyException(string message, decimal price) : base(message)
        {
            Price = price;
        }
    }
}