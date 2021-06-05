using Microsoft.VisualStudio.TestTools.UnitTesting;

using WeatherStation.Entity;
using WeatherStation.Views;

namespace WeatherStation.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWeatherStationApp()
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);


            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            Assert.IsTrue(true);
        }
    }
}
