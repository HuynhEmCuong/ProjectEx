using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Dtos;
using Web_API.Models;

namespace Web_API.Service.Interface
{
    public interface IPDCService:IService<PDCDto>
    {
        Task<List<PDCDto>> TestMapper();

        Task<string> SavePDCMapper();
    }
}
