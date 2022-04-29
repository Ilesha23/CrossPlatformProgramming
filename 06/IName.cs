using System;

namespace _06
{
    public interface IName : IComparable<Product>
    {
        string Name { get; }

        int CompareTo<T>(T data) where T : IName;
    }

    public interface IName<T> : IComparable<T>
    {
        string Name { get; }
    }
}