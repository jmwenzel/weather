using System;
using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using Weather.Factory;
using Weather.Factory.Interfaces;
using Weather.Factory.Services.Forecast.io;
using Weather.Wrapper;

namespace Weather.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void CheckForecastioIsActive()
        {
            var factory = new Mock<IFactory>();
            var forecastio = new Mock<IWeather>();

            factory.Setup(m => m.GetInstances()).Returns(new List<IWeather>(){new Forecastio()});

            var wrapper = new WeatherWrapper(factory.Object);

            var forecast = wrapper.ForecastLookup();

            Assert.AreEqual(forecast[0].Provider, "Forecast.io");
        }

    }
}
