using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EticaretApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EticaretApi.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
       DbSet<T>Table { get; }
    }
}