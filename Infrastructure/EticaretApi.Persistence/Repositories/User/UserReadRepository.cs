using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EticaretApi.Application.Repositories;
using EticaretApi.Domain.Entities;
using EticaretApi.Persistence.Context;

namespace EticaretApi.Persistence.Repositories
{
    public class UserReadRepository : ReadRepository<User>, IUserReadRepository
    {
        public UserReadRepository(EticaretDbContext context) : base(context)
        {
        }
    }
}