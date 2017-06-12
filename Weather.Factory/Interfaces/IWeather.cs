using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Weather.Factory.Models;

namespace Weather.Factory.Interfaces
{
    public interface IWeather
    {
        bool IsActive();
        ForeCastProvider GetWeather();
    }
}