using System.Collections.Generic;
using System.Linq;


namespace LartaDemo
{
    public class DifferenceController<T> where T : DifferenceItem
    {
        private readonly string filename;
        private List<DifferenceItem> result;
        DifferenceItemContext<T> context;

        public DifferenceController(string filename) 
        {
            this.filename = filename;
            context = new DifferenceItemContext<T>(filename);
            FindMin(); // by default find min and load that
        }

        private void FindMin()
        {
            var result = context.DifferenceItems.Where(n => n.Difference == context.DifferenceItems.Min(d => d.Difference));
            this.result = result.ToList();
        }

        public void FindLessThan(int number)
        {
            result = context.DifferenceItems.Where(n => n.Difference <= number).ToList();
        }

        public List<DifferenceItem> GetResult()
        {
            return result;
        }
    }
}