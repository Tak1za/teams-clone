using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamsClone.WeatherForecast.Interfaces;
using TeamsClone.WeatherForecast.Models;

namespace TeamsClone.WeatherForecast.Impl
{
    public class ForecastService : IForecastService
    {
        private readonly IForecastRepository _forecastRepository;

        public ForecastService(IForecastRepository forecastRepository)
        {
            _forecastRepository = forecastRepository;
        }

        public async Task<IList<Forecast>> Get()
        {
            var rng = new Random();

            var weathers = await _forecastRepository.GetWeatherAsync();

            return Enumerable.Range(1, 5).Select(index => new Forecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = weathers[rng.Next(weathers.Count)]
            }).ToList();
        }
    }
}
