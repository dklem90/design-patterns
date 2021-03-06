using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherStation.Entity;
using WeatherStation.Interfaces;

namespace WeatherStation.Views
{
    public class StatisticsDisplay : IDisplayElement, IObserver
    {
        private float _temperature;
        private float _humidity;
        private WeatherData _weatherData;

        public StatisticsDisplay(WeatherData weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }

        public void Update()
        {
            _temperature = _weatherData.Temperature;
            _humidity = _weatherData.Humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current conditions: {_temperature}F degrees and {_humidity}% humidity");
        }
    }
}
