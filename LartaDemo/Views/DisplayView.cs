using System;
using System.Collections.Generic;

namespace LartaDemo
{
    public abstract class DisplayView<T> where T : DifferenceItem
    {
        public DisplayView(){}

        public void OutputText(List<T> result)
        {
            foreach(var d in result)
                Console.WriteLine(DisplayText(d.Name,d.Difference));
        }

        public abstract string DisplayText(string name, int difference);

        //public string DisplayText(string name, int difference)
        //{
        //    return $"The {name} soccer club had the smallest difference of {difference} goals scored for vs against";
        //}



    }
}
