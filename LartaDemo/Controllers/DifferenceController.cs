using System.Collections.Generic;
using System.Linq;


namespace LartaDemo
{
    public class DifferenceController<T> where T : DifferenceItem
    {
        private List<T> result;
        IDifferenceItemContext<T> context;
        DisplayView<T> view;
        public DifferenceController(DisplayView<T> view, IDifferenceItemContext<T> context) 
        {
            this.view = view;
            this.context = context;
            FindMin(); // by default find min and load that
        }

        public void FindMin()
        {
            result = context.DifferenceItems.Where(n => n.Difference == context.DifferenceItems.Min(d => d.Difference)).ToList();
            UpdateView(result);
        }

        public void FindLessThan(int number)
        {
            result = context.DifferenceItems.Where(n => n.Difference <= number).ToList();
            UpdateView(result);
        }

        public void UpdateView(List<T> result)
        {
            view.OutputText(result);
        }

        public void Add(T item)
        {
            context.Add(item);
        }
    }
}