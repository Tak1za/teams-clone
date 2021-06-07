using AutoMapper;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using TeamsClone.Users.Interfaces;
using TeamsClone.Users.Models;

namespace TeamsClone.Users.Impl
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<UserInfo> GetByEmail(string email)
        {
            try
            {
                var user = await _userRepository.GetByEmail(email);
                return _mapper.Map<UserInfo>(user);
            }
            catch
            {
                return null;
            }
        }

        public async Task<UserInfo> GetById(string userId)
        {
            try
            {
                var user = await _userRepository.GetById(userId);
                return _mapper.Map<UserInfo>(user);
            }
            catch
            {
                return null;
            }
        }

        public async Task<IList<UserInfo>> GetUsers()
        {
            var userList = await _userRepository.GetUsers();
            return _mapper.Map<List<UserInfo>>(userList);
        }
    }
}
