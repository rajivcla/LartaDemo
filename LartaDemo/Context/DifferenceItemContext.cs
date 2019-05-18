using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace LartaDemo
{
    class DifferenceItemContext<T> where T : DifferenceItem
    {
        public List<DifferenceItem> DifferenceItems { get; set; }

        public DifferenceItemContext(string filename)
        {
            // read files and parse
            List<string[]> vals = FixedWidthTextParser.ReadFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"TestData\{filename}.dat"));

            // generate objects and load items
            DifferenceItems = new List<DifferenceItem>();
            foreach (var s in vals)
            {
                DifferenceItems.Add(DifferenceFactory.GetInstance<T>(s));
            }
            
        }
    }
}
