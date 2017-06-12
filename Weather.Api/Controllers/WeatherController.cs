using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Weather.Wrapper;

namespace Weather.Api.Controllers
{
    public class WeatherController : ApiController
    {
        private readonly IWrapper _wrapper;

        public WeatherController(): this(new WeatherWrapper())
        {
        }

        public WeatherController(IWrapper wrapper)
        {
            _wrapper = wrapper;
        }

        [HttpGet]
        public IHttpActionResult Forecast()
        {
            var result = _wrapper.ForecastLookup();
            return Ok(result);
        }
    }
}
