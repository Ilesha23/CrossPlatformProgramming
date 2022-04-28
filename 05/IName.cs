using System;

namespace _05
{
    public interface IName : IComparable
    {
        string Name { get; }
        decimal Price { get; }
    }
}