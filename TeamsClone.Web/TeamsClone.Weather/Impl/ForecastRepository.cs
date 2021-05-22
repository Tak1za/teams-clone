using Google.Cloud.Firestore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeamsClone.WeatherForecast.Interfaces;
using TeamsClone.WeatherForecast.Models;

namespace TeamsClone.WeatherForecast.Impl
{
    public class ForecastRepository : IForecastRepository
    {
        private readonly FirestoreDb _firestoreDb;

        public ForecastRepository(FirestoreDb firestoreDb)
        {
            _firestoreDb = firestoreDb;
        }

        public async Task<IList<string>> GetWeatherAsync()
        {
            var weatherSnaps = await _firestoreDb.Collection("weather").GetSnapshotAsync();
            var weatherList = new List<string>();

            foreach (var document in weatherSnaps.Documents)
            {
                var doc = document.ConvertTo<Weather>();
                weatherList.Add(doc.Type);
            }

            return weatherList;
        }
    }
}
