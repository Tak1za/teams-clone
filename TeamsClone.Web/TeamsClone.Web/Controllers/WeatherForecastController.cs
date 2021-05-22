using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeamsClone.WeatherForecast.Interfaces;
using TeamsClone.WeatherForecast.Models;

namespace TeamsClone.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IForecastService _forecastService;

        public WeatherForecastController(IForecastService forecastService)
        {
            _forecastService = forecastService;
        }

        [HttpGet]
        public async Task<IEnumerable<Forecast>> Get()
        {
            var res = await _forecastService.Get();
            return res;
        }
    }
}
