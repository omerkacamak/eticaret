using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EticaretApi.Domain.Entities;

namespace EticaretApi.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        //create
        Task<T> GetByIdAsync(Guid id,bool tracking = true);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method,bool tracking = true);
        IQueryable<T> GetAllAsync(Expression<Func<T, bool>>? method = null,bool tracking = true);

        //create antoher methods
        IQueryable<T> GetAllAsync(Expression<Func<T, bool>>? method=null,bool tracking = true, params Expression<Func<T, object>>[] includes);
        IQueryable<T> GetAllAsync( int pageNumber, int pageSize,Expression<Func<T, bool>>? method =null,bool tracking = true, params Expression<Func<T, object>>[] includes);
        Task<int> CountAsync(Expression<Func<T, bool>> method,bool tracking = true);

        

    }
}