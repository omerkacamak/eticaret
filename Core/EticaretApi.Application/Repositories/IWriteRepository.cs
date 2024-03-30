using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EticaretApi.Domain.Entities;

namespace EticaretApi.Application.Repositories
{
    public interface IWriteRepository<T>:IRepository<T> where T : BaseEntity
    {
        //create
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entities);
        Task<bool> RemoveAsync(T entity);
        Task<bool> RemoveRangeAsync(List<T> entities);
        Task<bool> UpdateAsync(T entity);
        //saveasync
        Task<int> SaveAsync();


    }
}