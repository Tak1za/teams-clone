using System.Collections.Generic;
using System.Threading.Tasks;
using TeamsClone.Users.Models;

namespace TeamsClone.Users.Interfaces
{
    public interface IUserService
    {
        Task<IList<UserInfo>> GetUsers();
        Task<UserInfo> GetById(string userId);
        Task<UserInfo> GetByEmail(string email);
    }
}
