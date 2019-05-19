using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LartaDemo
{
    public class SoccerView<T> : DisplayView<T> where T : SoccerItem
    {
        public SoccerView() { }

        public override string DisplayText(string name, int difference)
        {
            return $"The {name} soccer club had the smallest difference of {difference} goals scored for vs against";
        }

    }
   
}
