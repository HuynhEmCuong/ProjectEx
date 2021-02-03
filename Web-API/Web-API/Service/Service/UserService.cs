using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Dtos;
using Web_API.Helpers.Common;
using Web_API.Models;
using Web_API.Repository;
using Web_API.Service.Interface;

namespace Web_API.Service.Service
{
    public class UserService : Service<UserDto, User>, IUserService
    {
        private readonly IRepository<User> _repo;
        private readonly IMapper _mapper;
        private readonly MapperConfiguration _configuration;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public UserService(IRepository<User> repo, IMapper mapper, MapperConfiguration configuration, IWebHostEnvironment webHostEnvironment) : base(repo, mapper, configuration)
        {
            _repo = repo;
            _mapper = mapper;
            _configuration = configuration;
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<UserDto> MapUserDifferentProperTy()
        {
            var data = _mapper.Map<User, UserDto>(_repo.FindAll().FirstOrDefault());
            return await Task.FromResult(data);
        }

        public Task<OperationResult> SaveListMap(List<UserDto> models)
        {
            throw new NotImplementedException();
        }

        public override async Task<PageListUtility<UserDto>> Search(string keyword, PaginationParams parms)
        {
            var queryData = _repo.FindAll();
            if (!String.IsNullOrEmpty(keyword))
            {
                queryData = queryData.Where(x => x.UserName.Contains(keyword.ToString()) ||
                                                     x.EmpName.Contains(keyword.ToString()) ||
                                                     x.UpdateBy.Contains(keyword.ToString()));
            }
            return await PageListUtility<UserDto>.PageListAsync(queryData.AsNoTracking().ProjectTo<UserDto>(_configuration).OrderByDescending(x => x.UpdateDate), parms.PageNumber, parms.PageSize);
        }

        public async Task<OperationResult> UpLoadFile(IFormFile file)
        {
            OperationResult result ;

            string folderPath = _webHostEnvironment.WebRootPath + $@"/upload/";

            string path = Path.Combine(folderPath, file.FileName);

            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                using (FileStream fs = File.Create(path))
                {
                    file.CopyTo(fs);
                    fs.Flush();
                }
                result = new OperationResult { Message = "upload file success ", Success = true };
            }
            catch (Exception ex)
            {

                result = new OperationResult { Message = ex.ToString(), Success = true };
            }

            return await Task.FromResult(result);
        }
    }
}
