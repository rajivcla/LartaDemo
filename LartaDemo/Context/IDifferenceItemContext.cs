using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LartaDemo
{
    public interface IDifferenceItemContext<T>
    {
        List<T> DifferenceItems { get; set; }
        void Add(T item);
        void Remove(T item);
    }
}
