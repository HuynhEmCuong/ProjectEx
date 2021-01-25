using AutoMapper;
using Web_API.Dtos;
using Web_API.Models;

namespace Web_API.Helpers
{
    public class DtoToEfMappingProfile : Profile
    {
        public DtoToEfMappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Building, BuildingDto>();
            CreateMap<PDCDto, PDC>().ForMember(
                s => s.Visible,
                d =>
                {
                    d.Condition(src => src.Visible == true);
                    d.MapFrom(src => src.Visible);
                }).ReverseMap().ForMember(
                  s => s.NameCode,
                  d => d.MapFrom(r => r.PDCCode));

            //CreateMap<PDC, PDCDto>().ForMember(
            //    s => s.
            //    );

        }
    }
}