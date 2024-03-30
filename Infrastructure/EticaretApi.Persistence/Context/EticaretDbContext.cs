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

        //onmodel creating
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     // cart and user relation 1-1
        //     modelBuilder.Entity<Cart>()
        //         .HasOne(c=>c.User)
        //         .WithOne(u => u.Cart)
        //         .HasForeignKey<Cart>(c => c.UserId)
        //         .OnDelete(DeleteBehavior.NoAction);
                

            

        // }
        


        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<User> Users { get; set; }
    }
}