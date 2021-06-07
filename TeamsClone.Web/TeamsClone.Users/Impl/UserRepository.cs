using Google.Cloud.Firestore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TeamsClone.Users.Interfaces;
using TeamsClone.Users.Models;

namespace TeamsClone.Users.Impl
{
    public class UserRepository : IUserRepository
    {
        private readonly FirestoreDb _firestoreDb;

        public UserRepository(FirestoreDb firestoreDb)
        {
            _firestoreDb = firestoreDb;
        }

        public async Task<User> GetByEmail(string email)
        {
            var userSnap = await _firestoreDb.Collection("users").WhereEqualTo("email", email).GetSnapshotAsync();
            foreach(var docSnap in userSnap.Documents)
            {
                if (docSnap.Exists)
                {
                    var doc = docSnap.ConvertTo<User>();
                    doc.Id = docSnap.Id;
                    return doc;
                }
            }

            return null;
        }

        public async Task<User> GetById(string userId)
        {
            var userSnap = await _firestoreDb.Document($"users/{userId}").GetSnapshotAsync();
            var user = userSnap.ConvertTo<User>();
            user.Id = userSnap.Id;
            return user;
        }

        public async Task<IList<User>> GetUsers()
        {
            var userSnaps = await _firestoreDb.Collection("users").GetSnapshotAsync();
            var usersList = new List<User>();

            foreach (var document in userSnaps.Documents)
            {
                var doc = document.ConvertTo<User>();
                doc.Id = document.Id;
                usersList.Add(doc);
            }

            return usersList;
        }
    }
}
