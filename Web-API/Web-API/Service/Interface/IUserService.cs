using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Dtos;
using Web_API.Helpers.Common;

namespace Web_API.Service.Interface
{
    public interface IUserService : IService<UserDto>
    {
        Task<UserDto> MapUserDifferentProperTy();

        Task<OperationResult> SaveListMap(List<UserDto> models);
    }

}
