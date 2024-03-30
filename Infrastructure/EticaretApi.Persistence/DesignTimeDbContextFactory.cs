using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EticaretApi.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EticaretApi.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EticaretDbContext>
    {
        public EticaretDbContext CreateDbContext(string[] args)
        {
            //create
            DbContextOptionsBuilder<EticaretDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseSqlServer("Server=DESKTOP-7P5OTV2\\SQLEXPRESS;Database=EticaretDB;Trusted_Connection=True;TrustServerCertificate=True");
            return new EticaretDbContext(dbContextOptionsBuilder.Options);
        }
    }
}