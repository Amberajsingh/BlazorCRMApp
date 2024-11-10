using AutoMapper;
using Blazor.API.Data.Entities;
using Shared.Lib.Dto;

namespace Blazor.API.Infrastructure.AutoMapperProfiles
{
    public class FlagProfile : Profile
    {
        public FlagProfile() {
            CreateMap<FlagDto, FlagMaster>();

            CreateMap<FlagMaster, FlagDto>();
        }
    }
}
