using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Service.Interface;

namespace Web_API.Controllers
{
    
    public class PDCController:BaseController
    {
        private readonly IPDCService _service;

        public PDCController(IPDCService service)
        {
            _service = service;
        }

        public async Task<IActionResult> GetAllPDC() => Ok(await _service.GetALl());
    }
}
