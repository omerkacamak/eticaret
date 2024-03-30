using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EticaretApi.Application.Repositories;
using EticaretApi.Domain.Entities;
using EticaretApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;

namespace EticaretApi.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        //create our dbcontext
        private readonly EticaretDbContext _context;
        public WriteRepository(EticaretDbContext context)
        {
            _context = context;
        }
        

        public DbSet<T> Table => _context.Set<T>();

        public Task<bool> AddAsync(T entity)
        {
            //create AddAsync
            Table.Add(entity);
            return Task.FromResult(true);
        }

        public Task<bool> AddRangeAsync(List<T> entities)
        {
            //create AddRangeAsync
            Table.AddRange(entities);
            return Task.FromResult(true);
        }

        public Task<bool> RemoveAsync(T entity)
        {
            //create RemoveAsync
            Table.Remove(entity);
            return Task.FromResult(true);
        }

        public Task<bool> RemoveRangeAsync(List<T> entities)
        {
            //create RemoveRangeAsync
            Table.RemoveRange(entities);
            return Task.FromResult(true);
        }

        public Task<int> SaveAsync()
        {
            //create SaveAsync
            return _context.SaveChangesAsync();
        }

        public Task<bool> UpdateAsync(T entity)
        {
            //create UpdateAsync
            Table.Update(entity);
            return Task.FromResult(true);
        }
    }
}