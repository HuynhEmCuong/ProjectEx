using AutoMapper;
using Web_API.Dtos;
using Web_API.Models;

namespace Web_API.Helpers
{
    public class EfToDtoMappingProfile : Profile
    {
        public EfToDtoMappingProfile()
        {
            CreateMap<UserDto, User>();
           
        }

    }
}