using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LartaDemo
{
    public class SoccerItem : DifferenceItem
    {
        public int P      { get; set; }
        public int W { get; set; }
        public int L { get; set; }
        public int D { get; set; }
        public int F { get; set; }
        public int A { get; set; }
        public int Pts { get; set; }

        public SoccerItem(params string[] s) : base() {
            Name = s[0];
            Int32.TryParse(s[1], out int p);
            P = p;
            Int32.TryParse(s[2], out int w);
            W = w;
            Int32.TryParse(s[3], out int l);
            L = l;
            Int32.TryParse(s[4], out int d);
            D = d;
            Int32.TryParse(s[5], out int f);
            F = f;
            Int32.TryParse(s[6], out int a);
            A = a;
            Int32.TryParse(s[7], out int pts);
            Pts = pts;
            Difference = Math.Abs(F - A);
        }

        //public override string DisplayText()
        //{
        //    return $"The {Name} soccer club had the smallest difference of {Difference} goals scored for vs against";
        //}

        public SoccerItem() { }
    }
}
