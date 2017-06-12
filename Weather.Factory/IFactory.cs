using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Weather.Factory.Interfaces;

namespace Weather.Factory
{
    public interface IFactory
    {
        IList<IWeather> GetInstances();
    }
}