using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weather.Factory.Models;

namespace Weather.Wrapper
{
    public interface IWrapper
    {
        IList<ForeCastProvider> ForecastLookup();
    }
}
