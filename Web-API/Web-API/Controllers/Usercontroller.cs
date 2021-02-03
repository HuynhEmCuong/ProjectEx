using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Dtos;
using Web_API.Helpers.Common;
using Web_API.Routes;
using Web_API.Service.Interface;

namespace Web_API.Controllers
{
    public class Usercontroller : BaseController
    {
        private readonly IUserService _service;

        public Usercontroller(IUserService service)
        {
            _service = service;
        }


        [HttpGet, Route(ApiRouter.User.GetAllUser)]
        public async Task<IActionResult> GetAllUser() => Ok(await _service.GetALL());

        [HttpGet, Route(ApiRouter.User.SerachUser)]
        public async Task<IActionResult> SearchUser([FromQuery] PaginationParams page, string keyword) => Ok(await _service.Search(keyword, page));

        [HttpPost, Route(ApiRouter.User.AddUser)]
        public async Task<IActionResult> AddUser(UserDto user) => Ok(await _service.Add(user));


        [HttpPost, Route(ApiRouter.User.UpLoadUser)]
        public async Task<IActionResult> UpLoadFile(IFormFile file)
        {
            return Ok(await _service.UpLoadFile(file));
        }

    }
}
