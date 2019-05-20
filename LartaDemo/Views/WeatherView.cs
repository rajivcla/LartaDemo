using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LartaDemo
{
    class WeatherView<T> : DisplayView<T> where T : WeatherItem
    {
        public WeatherView() { }

        public override string DisplayText(string name, int difference)
        {
            return $"Day #{name} had the smallest difference of {difference} degrees between max & min temperature";
        }
    }
}
