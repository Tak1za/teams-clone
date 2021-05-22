using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TeamsClone.WeatherForecast.Interfaces
{
    public interface IForecastRepository
    {
        Task<IList<string>> GetWeatherAsync();
    }
}
