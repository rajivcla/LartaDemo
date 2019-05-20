using System.Collections.Generic;

namespace LartaDemo
{
    public interface IDifferenceItemContext<T>
    {
        List<T> DifferenceItems { get; set; }
        void Add(T item);
        void Remove(T item);
    }
}
