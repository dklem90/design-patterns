using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WeatherStation.Entity;
using WeatherStation.Interfaces;

namespace WeatherStation.Views
{
    public class ForecastDisplay : IDisplayElement, IObserver
    {
        private float _temperature;
        private float _humidity;
        private WeatherData _weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = temperature;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
        }
    }
}
