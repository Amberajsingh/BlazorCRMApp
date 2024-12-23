using AutoMapper;
using Blazor.API.Data.Entities;
using Shared.Lib.Dto;

namespace Blazor.API.Infrastructure.AutoMapperProfiles
{
    public class MasterProfile : Profile
    {
        public MasterProfile()
        {
            CreateMap<DesignationRequestDto, DesignationMaster>();

            CreateMap<DesignationMaster, DesignationResponseDto>();

            CreateMap<CountryMaster, SelectListDto>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));

            CreateMap<StateMaster, SelectListDto>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));

            CreateMap<CityMaster, SelectListDto>()
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));

            CreateMap<UserTimeZones, SelectListDto>()
               .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.TimeZone))
               .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));

            CreateMap<DesignationMaster, SelectListDto>()
              .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.Name))
              .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id));
        }
    }
}
