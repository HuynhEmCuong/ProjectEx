using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Dtos;
using Web_API.Helpers.Common;
using Web_API.Models;
using Web_API.Repository;
using Web_API.Service.Interface;

namespace Web_API.Service.Service
{
    public class PDCService : Service<PDCDto, PDC>, IPDCService
    {
        private readonly IRepository<PDC> _repo;
        private readonly IMapper _mapper;
        private readonly MapperConfiguration _configuration;

        public PDCService(IRepository<PDC> repo, IMapper mapper, MapperConfiguration configuration) : base(repo, mapper, configuration)
        {
            _repo = repo;
            _mapper = mapper;
            _configuration = configuration;
        }

   
        public override async Task<PageListUtility<PDCDto>> Search(string keyword, PaginationParams parms)
        {
            var query = _repo.FindAll();

            if (!String.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.PDCName.Contains(keyword) || x.PDCCode.Contains(keyword));
            }

            return await PageListUtility<PDCDto>.PageListAsync(query.AsNoTracking().ProjectTo<PDCDto>(_configuration), parms.PageNumber, parms.PageSize);
        }

        public async Task<List<PDCDto>> TestMapper()
        {
            var result = _mapper.Map<List<PDCDto>>(_repo.FindAll());
            return await Task.FromResult(result);
        }

        public async Task<string> SavePDCMapper()
        {
            var query = _repo.FindAll();
            throw new NotImplementedException();
        }

   

    }
}
