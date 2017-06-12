using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Weather.Factory.Models
{
    public class ForeCastProvider
    {
        public string Provider { get; set; }
        public IList<DailyForecast> DailyForeCast { get; set; }
    }
}