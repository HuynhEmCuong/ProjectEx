using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Helpers.Common;

namespace Web_API.Service
{
    public interface IService<T> where T : class
    {
        Task<List<T>> GetALl();
        Task<OperationResult> Add(T model);
        Task<OperationResult> Update(T model);
        Task<OperationResult> Delete(T model);
        Task<PageListUtility<T>> Search(string keyword, PaginationParams page);
    }
}
