using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using Weather.Factory.Interfaces;

namespace Weather.Factory
{
    public class WeatherFactory : IFactory
    {
        Dictionary<string, Type> _weatherServices;

        public WeatherFactory()
        {
            LoadTypes();
        }

        private void LoadTypes()
        {
            _weatherServices = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly)
            {
                if (type.GetInterface(typeof(IWeather).ToString()) != null)
                {
                    _weatherServices.Add(type.Name.ToLower(), type);
                }
            }
        }

        public IList<IWeather> GetInstances()
        {
            IList<IWeather> instances = new List<IWeather>();
            foreach (var service in _weatherServices)
            {
                if (service.Key != null)
                {
                    var item = Activator.CreateInstance(_weatherServices[service.Key]) as IWeather;
                    if (item != null && item.IsActive())
                        instances.Add(item);
                }
            }
            return instances;
        }

    }
}