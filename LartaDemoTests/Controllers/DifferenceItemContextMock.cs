using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LartaDemo;

namespace LartaDemoTests.Tests
{
    class DifferenceItemContextMock<T> : IDifferenceItemContext<T> where T : DifferenceItem
    {
        public List<T> DifferenceItems { get; set; }
        public DifferenceItemContextMock(){
            DifferenceItems = new List<T>();
        }

        public void Add(T item)
        {
            DifferenceItems.Add(item);
        }

        public void Remove(T item)
        {
            DifferenceItems.Remove(item);
        }
    }
}
