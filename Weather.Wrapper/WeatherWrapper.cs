using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Factory;
using Weather.Factory.Models;

namespace Weather.Wrapper
{
    public class WeatherWrapper : IWrapper
    {
        private readonly IFactory _weatherFactory;
        public WeatherWrapper() : this(new WeatherFactory())    
        {
        }

        public WeatherWrapper(IFactory weatherFactory)
        {
            _weatherFactory = weatherFactory;
        }
        public IList<ForeCastProvider> ForecastLookup()
        {
            var lookup = new List<ForeCastProvider>();
            foreach (var item in _weatherFactory.GetInstances())
            {
                lookup.Add(item.GetWeather());
            }
            return lookup;
        }
    }
}
