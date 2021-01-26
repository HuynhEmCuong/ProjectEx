using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Dtos;
using Web_API.Helpers.Common;
using Web_API.Models;
using Web_API.Repository;
using Web_API.Service.Interface;
using Web_API.ViewModel;

namespace Web_API.Service.Service
{
    public class AuthService : IAuthService
    {
        private readonly IRepository<User> _repo;
        private readonly IMapper _mapper;
        private readonly MapperConfiguration _configuration;

        public AuthService(IRepository<User> repo, IMapper mapper, MapperConfiguration configuration)
        {
            _repo = repo;
            _mapper = mapper;
            _configuration = configuration;
        }

        public Task<UserDto> Login(LoginViewModel userLogin)
        {
            var user = _repo.FindAll(x => x.UserName == userLogin.UserName && x.HashPass == userLogin.Password).FirstOrDefault();

            
            throw new NotImplementedException();
        }
    }

    public class AuthenResult
    {
        public string Token { get; set; }
        public UserDto User { get; set; }
    }
}
