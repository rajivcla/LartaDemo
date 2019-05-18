using System;

namespace LartaDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayView<SoccerItem> displaySoccer = new DisplayView<SoccerItem>("soccer");
            DisplayView<WeatherItem> displayWeather = new DisplayView<WeatherItem>("w_data");

            Console.Read();
        }
    }
}
