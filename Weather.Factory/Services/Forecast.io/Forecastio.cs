using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using Weather.Factory.Interfaces;
using Weather.Factory.Models;

namespace Weather.Factory.Services.Forecast.io
{
    public class Forecastio : IWeather
    {
        public bool IsActive()
        {
            return Convert.ToBoolean(ConfigurationManager.AppSettings["Forecast.ioIsActive"]);
        }

        public ForeCastProvider GetWeather()
        {
            var weather = new ForeCastProvider()
            {
                Provider = ConfigurationManager.AppSettings["Forecast.io"],
                DailyForeCast = SearchForecast()
            };
            return weather;
        }

        private IList<DailyForecast> SearchForecast()
        {
            var forecast = new List<DailyForecast>()
            {
                new DailyForecast() { Day = "MON", Forecast = "19°C"},
                new DailyForecast() { Day = "TUE", Forecast = "20°C"},
                new DailyForecast() { Day = "WED", Forecast = "21°C"},
                new DailyForecast() { Day = "THU", Forecast = "21°C"},
                new DailyForecast() { Day = "FRI", Forecast = "20°C"},
                new DailyForecast() { Day = "SAT", Forecast = "19°C"},
                new DailyForecast() { Day = "SUN", Forecast = "19°C"}
            };
            return forecast;
        }
    }
}