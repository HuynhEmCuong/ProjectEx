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

    public class PDCController : BaseController
    {
        private readonly IPDCService _service;

        public PDCController(IPDCService service)
        {
            _service = service;
        }

        [HttpGet, Route(ApiRouter.PDC.GetAllPDC)]
        public async Task<IActionResult> GetAllPDC() => Ok(await _service.GetALL());

        [HttpGet, Route(ApiRouter.PDC.SerachPDC)]
        public async Task<IActionResult> SearchPDC([FromQuery] PaginationParams parms, string keyword) => Ok(await _service.Search(keyword, parms));

        [HttpPost, Route(ApiRouter.PDC.AddPDC)]
        public async Task<IActionResult> AddPDC(PDCDto model) => Ok(await _service.Add(model));


        [HttpPut, Route(ApiRouter.PDC.UpdatePDC)]
        public async Task<IActionResult> UpdatePDC(PDCDto model) => Ok(await _service.Update(model));


        [HttpDelete, Route(ApiRouter.PDC.DeletePDC)]
        public async Task<IActionResult> DeletePDC(PDCDto model) => Ok(await _service.Delete(model));

        [HttpGet("TestMapper")]
        public async Task<IActionResult> TestMapper() => Ok(await _service.TestMapper());
    }
}
