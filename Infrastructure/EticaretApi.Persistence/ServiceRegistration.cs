using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EticaretApi.Application.Repositories;
using EticaretApi.Persistence.Context;
using EticaretApi.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EticaretApi.Persistence
{
    public static class ServiceRegistration
    {
        // create addpersistence services for db context

        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<EticaretDbContext>(options =>
                options.UseSqlServer("Server=DESKTOP-T5SD4LD\\SQLEXPRESS;Database=EticaretDB;Trusted_Connection=True;TrustServerCertificate=True"));

                //customer and product repositories for db context and persistence services

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IUserReadRepository, UserReadRepository>();
            services.AddScoped<IUserWriteRepository, UserWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();

        }



    }
}