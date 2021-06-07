using AutoMapper;
using System.Collections.Generic;
using TeamsClone.Users.Models;

namespace TeamsClone.Users.Mapper
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<User, UserInfo>().ReverseMap();
        }
    }
}
