using Newtonsoft.Json;

namespace TeamsClone.Users.Models
{
    public class UserInfo
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }
    }
}
