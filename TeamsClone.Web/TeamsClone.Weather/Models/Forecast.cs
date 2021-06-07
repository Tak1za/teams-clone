using Newtonsoft.Json;
using System;

namespace TeamsClone.WeatherForecast.Models
{
    public class Forecast
    {
        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("temperatureC")]
        public int TemperatureC { get; set; }

        [JsonProperty("temperatureF")]
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }
}
