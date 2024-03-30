using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EticaretApi.Application.Repositories;
using EticaretApi.Domain.Entities;
using EticaretApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace EticaretApi.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        // use our dbcontext
        private readonly EticaretDbContext _context;
        public ReadRepository(EticaretDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public Task<int> CountAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            //create countasync
            return Table.Where(method).CountAsync();


        }

        public IQueryable<T> GetAllAsync(Expression<Func<T, bool>>? method = null, bool tracking = true)
        {
            //create GetAllAsync, use Table
            var query = method == null ? Table.AsQueryable() : Table.Where(method).AsQueryable();
            //tracking control
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return query;

            
        }

        public IQueryable<T> GetAllAsync(Expression<Func<T, bool>>? method=null,bool tracking = true, params Expression<Func<T, object>>[] includes)
        {
            //create table and includes with tracking control
            var query = method == null ? Table.AsQueryable() : Table.Where(method).AsQueryable();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return query;

            
            
            
        }

        public IQueryable<T> GetAllAsync( int pageNumber, int pageSize,Expression<Func<T, bool>>? method=null,bool tracking = true, params Expression<Func<T, object>>[] includes)
        {
            //create table and includes with tracking control
            var query = method == null ? Table.AsQueryable() : Table.Where(method).AsQueryable();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return query.Skip((pageNumber - 1) * pageSize).Take(pageSize);

            
           
        }

        public async Task<T> GetByIdAsync(Guid id,bool tracking = true)
        {
           //create GetByIdAsync with tracking control
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync(x => x.Id == id);
            
            
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method,bool tracking = true)
        {
           //create GetSingleAsync with tracking control
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return await query.FirstOrDefaultAsync(method);
          
           
        }
    }
}