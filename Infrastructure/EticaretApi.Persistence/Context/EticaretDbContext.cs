using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EticaretApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EticaretApi.Persistence.Context
{
    public class EticaretDbContext:DbContext
    {
        //ctor dbcontextopitons
        public EticaretDbContext(DbContextOptions<EticaretDbContext> options):base(options)
        {

        }



        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<User> Users { get; set; }


        //add savechangesasync interceptor

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<BaseEntity>().ToList())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedAt = DateTime.Now;
                        entry.Entity.CreatedBy = "sistem";
                        break;

                    case EntityState.Modified:
                        entry.Entity.CreatedAt = DateTime.Now;
                        entry.Entity.UpdatedBy = "sistem";
                        break;

                }

            }
            return base.SaveChangesAsync(cancellationToken);

        }


        


    }
}