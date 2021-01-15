using AutoMapper;
using AutoMapper.QueryableExtensions;
using LinqKit;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Helpers.Common;
using Web_API.Repository;

namespace Web_API.Service
{
    public class Service<T, TRepo> : IService<T> where T : class where TRepo : class
    {
        private readonly IRepository<TRepo> _repo;
        private readonly IMapper _mapper;
        private readonly MapperConfiguration _configuration;
        private OperationResult operationResult;

        public Service(IRepository<TRepo> repo, IMapper mapper, MapperConfiguration configuration)
        {
            _repo = repo;
            _mapper = mapper;
            _configuration = configuration;
        }

        public virtual async Task<OperationResult> Add(T model)
        {
            var item = _mapper.Map<TRepo>(model);
            try
            {
                _repo.Add(item);
                await _repo.Save();
                operationResult = new OperationResult
                {
                    Success = true,
                    Message = MessageUtility.AddSuccess,
                };
            }
            catch (Exception )
            {
                operationResult = new OperationResult
                {
                    Success = false,
                    Message = MessageUtility.AddError,
                };
            }
            return operationResult;
        }

        public virtual async  Task<OperationResult> Delete(T model)
        {
            var item = _mapper.Map<TRepo>(model);

            try
            {
                _repo.Remove(item);
                await _repo.Save();
                operationResult = new OperationResult
                {
                    Success = true,
                    Message = MessageUtility.DeleteSuccess,
                };
            }
            catch (Exception)
            {
                operationResult = new OperationResult
                {
                    Success = false,
                    Message = MessageUtility.DeleteError,
                };
            }
            return operationResult;
        }

        public virtual async Task<List<T>> GetALl()
        {
            return await _repo.FindAll().AsNoTracking().ProjectTo<T>(_configuration).ToListAsync();
        }

        public virtual Task<PageListUtility<T>> Search(string keyword, PaginationParams page)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<OperationResult> Update(T model)
        {
            var item = _mapper.Map<TRepo>(model);

            try
            {
                _repo.Update(item);
                await _repo.Save();
                operationResult = new OperationResult
                {
                    Success = true,
                    Message = MessageUtility.UpdateSuccess,
                };
            }
            catch (Exception)
            {
                operationResult = new OperationResult
                {
                    Success = false,
                    Message = MessageUtility.UpdateError,
                };
            }
            return operationResult;
        }
    }
}
