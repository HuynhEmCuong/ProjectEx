using AutoMapper;
using Web_API.Dtos;
using Web_API.Models;

namespace Web_API.Helpers
{
    public class DtoToEfMappingProfile : Profile
    {
        public DtoToEfMappingProfile()
        {
            CreateMap<User, UserDto>();
          
        }
    }
}