using AutoMapper;
using Blazor.API.Data.Entities;
using Shared.Lib.Dto;

namespace Blazor.API.Infrastructure.AutoMapperProfiles
{
    public class DesignationProfile : Profile
    {
        public DesignationProfile()
        {
            CreateMap<DesignationRequestDto, DesignationMaster>();

            CreateMap<DesignationMaster, DesignationResponseDto>();
        }
    }
}
