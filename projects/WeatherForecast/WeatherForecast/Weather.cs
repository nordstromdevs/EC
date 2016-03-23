using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecast
{
    public enum WeatherType
    {
        Rainy,
        Sunny,
        Foggy,
        Snowy,
        Frosty,
        SuperNice,
        HailStorm
    }

    class Weather
    {
        private Random _random;

        public Weather()
        {
            _random = new Random();
        }

        public WeatherType Forecast(DateTime time)
        {
            int numberOfAlternatives = Enum.GetNames(typeof(WeatherType)).Length;
            int randomNumber = _random.Next(numberOfAlternatives);

            WeatherType result = (WeatherType)randomNumber;

            if (time.DayOfWeek == DayOfWeek.Sunday)
                result = WeatherType.SuperNice;
            else if (time.Month == 1)
                result = WeatherType.Snowy;

            return result;
        }
    }
}
