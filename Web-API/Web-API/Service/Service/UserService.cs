﻿using AutoMapper;
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
    public class UserService : Service<UserDto, User>, IUserService
    {
        private readonly IRepository<User> _repo;
        private readonly IMapper _mapper;
        private readonly MapperConfiguration _configuration;

        public UserService(IRepository<User> repo, IMapper mapper, MapperConfiguration configuration) : base(repo, mapper, configuration)
        {
            _repo = repo;
            _mapper = mapper;
            _configuration = configuration;
        }


        public override async Task<PageListUtility<UserDto>> Search(string keyword, PaginationParams page)
        {
            var queryData = _repo.FindAll();
            if (!String.IsNullOrEmpty(keyword))
            {
                queryData = queryData.Where(x => x.UserName.Contains(keyword.ToString()) ||
                                                     x.EmpName.Contains(keyword.ToString()) ||
                                                     x.UpdateBy.Contains(keyword.ToString()));
            }
            return await PageListUtility<UserDto>.PageListAsync(queryData.AsNoTracking().ProjectTo<UserDto>(_configuration).OrderByDescending(x => x.UpdateDate), page.PageNumber, page.PageSize);
        }

        public void test()
        {
            throw new NotImplementedException();
        }

    }
}
