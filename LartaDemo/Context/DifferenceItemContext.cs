using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace LartaDemo
{
    public class DifferenceItemContext<T> : IDifferenceItemContext<T> where T : DifferenceItem
    {
        public List<T> DifferenceItems { get; set; } 

        public DifferenceItemContext(string filename)
        {
            // read files and parse
            List<string[]> vals = FixedWidthTextParser.ReadFile(Path.Combine(Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location), $@"TestData\{filename}.dat"));

            // generate objects and load items
            DifferenceItems = new List<T>();
            foreach (var s in vals)
            {
                DifferenceItems.Add(DifferenceFactory.GetInstance<T>(s));
            }
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
