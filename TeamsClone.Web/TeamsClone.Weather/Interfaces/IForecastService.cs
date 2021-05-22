using System.Collections.Generic;
using System.Threading.Tasks;
using TeamsClone.WeatherForecast.Models;

namespace TeamsClone.WeatherForecast.Interfaces
{
    public interface IForecastService
    {
        Task<IList<Forecast>> Get();
    }
}
