using AutoMapper;
using Blazor.API.Data.Entities;
using Shared.Lib.Dto;

namespace Blazor.API.Infrastructure.AutoMapperProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UsersDto, Users>();

            CreateMap<Users, UsersDto>();
        }
    }
}
