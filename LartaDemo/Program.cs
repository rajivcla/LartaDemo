using System;

namespace LartaDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            SoccerView<SoccerItem> dvSoccer = new SoccerView<SoccerItem>();
            DifferenceItemContext <SoccerItem> soccerContext = new DifferenceItemContext<SoccerItem>("soccer");
            WeatherView<WeatherItem> dvWeather = new WeatherView<WeatherItem>();
            DifferenceItemContext<WeatherItem> weatherContext = new DifferenceItemContext<WeatherItem>("w_data");


            DifferenceController<SoccerItem> dcSoccer = new DifferenceController<SoccerItem>(dvSoccer, soccerContext);
            DifferenceController<WeatherItem> dcWeather = new DifferenceController<WeatherItem>(dvWeather, weatherContext);


            Console.Read();
        }
    }
}
