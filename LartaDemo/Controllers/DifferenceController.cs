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
            FindMin();
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

        //private void GetDifference()
        //{
        //    // read files and parse
        //    List<string[]> vals = FixedWidthTextParser.ReadFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"TestData\{filename}.dat"));

        //    // find min values
        //    IEnumerator<string[]> i = vals.GetEnumerator();
        //    i.MoveNext();

        //    //set first item as current min value
        //    min = new List<DifferenceItem>();
        //    min.Add(DifferenceFactory.GetInstance<T>(i.Current)); 
        //    while (i.MoveNext())
        //    {
        //        DifferenceItem next = DifferenceFactory.GetInstance<T>(i.Current); 
        //        // find any smaller min
        //        if (next.Difference < min[0].Difference)
        //        {
        //            min[0] = next;
        //        }
        //    }
        //}



        //public List<DifferenceItem> GetDifferenceDB() //where T : DifferenceItem
        //{
        //    // read files and parse
        //    List<string[]> vals = FixedWidthTextParser.ReadFile(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"TestData\{filename}.dat"));

        //    //load in to DB, find min value, then just call and return all min value items.  loop through dbcontext in display
        //    using (DifferenceItemContext context = new DifferenceItemContext())
        //    {
        //        //delete all old items
        //        //string name = (context as IObjectContextAdapter).ObjectContext.CreateObjectSet<T>().EntitySet.Name;
        //        //context.Database.ExecuteSqlCommand($"delete from {typeof(T).Name}");

        //        //load new items
        //        foreach (var s in vals)
        //        {
        //            DifferenceItem d = DifferenceFactory.GetInstance<DifferenceItem>(s); // no constructor now...
        //            context.DifferenceItems.Add(d);
        //            context.SaveChanges();
        //        }

        //        //var results = context.DifferenceItems.Select();
        //        var result = context.DifferenceItems.Where(n => n.Difference <= 8);// context.DifferenceItems.Min(d => d.Difference));
        //        //return result.ToList<T>();
        //        return result.ToList<DifferenceItem>();
        //    }
        //}


    }
}