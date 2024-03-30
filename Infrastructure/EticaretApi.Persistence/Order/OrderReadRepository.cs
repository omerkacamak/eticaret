using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EticaretApi.Application.Repositories;
using EticaretApi.Domain.Entities;
using EticaretApi.Persistence.Context;
using EticaretApi.Persistence.Repositories;

namespace EticaretApi.Persistence
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(EticaretDbContext context) : base(context)
        {
        }
    }
}