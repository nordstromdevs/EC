using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather myWeather = new Weather();
            var result = myWeather.Forecast(DateTime.Now);
            var result2 = myWeather.Forecast(new DateTime(2016, 3, 20));

            Console.WriteLine("Today it is " + result);
            Console.WriteLine("On Sunday it is " + result2);

            Console.ReadKey();
        }
    }
}
