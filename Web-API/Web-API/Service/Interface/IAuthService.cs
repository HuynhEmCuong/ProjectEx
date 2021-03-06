﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Dtos;
using Web_API.Helpers.Common;
using Web_API.ViewModel;

namespace Web_API.Service.Interface
{
    public interface IAuthService
    {
        Task<UserDto> Login(LoginViewModel userLogin);

    }
}
