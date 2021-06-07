using Google.Cloud.Firestore;

namespace TeamsClone.Users.Models
{
    [FirestoreData]
    public class User
    {
        public string Id { get; set; }

        [FirestoreProperty("email")]
        public string Email { get; set; }

        [FirestoreProperty("firstName")]
        public string FirstName { get; set; }

        [FirestoreProperty("lastName")]
        public string LastName { get; set; }

    }
}
