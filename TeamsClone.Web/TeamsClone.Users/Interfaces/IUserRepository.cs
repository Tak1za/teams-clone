using System.Collections.Generic;
using System.Threading.Tasks;
using TeamsClone.Users.Models;

namespace TeamsClone.Users.Interfaces
{
    public interface IUserRepository
    {
        Task<IList<User>> GetUsers();
        Task<User> GetById(string userId);
        Task<User> GetByEmail(string email);
    }
}
