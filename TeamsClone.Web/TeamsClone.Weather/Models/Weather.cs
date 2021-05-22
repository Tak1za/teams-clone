using Google.Cloud.Firestore;

namespace TeamsClone.WeatherForecast.Models
{
    [FirestoreData]
    public class Weather
    {
        [FirestoreProperty("type")]
        public string Type { get; set; }
    }
}
