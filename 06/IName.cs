using System;

namespace _06
{
    public interface IName : IComparable
    {
        string Name { get; }
    }

    public interface IName<T> : IName
    {

    }
}