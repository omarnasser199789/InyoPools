using InyoPools.Core.Domain.Model;
using InyoPools.Core.Domain.Model.Order;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace InyoPools.Infrastructure
{
    public class InyoPoolsDbContext : IdentityDbContext<IdentityUser>
    {




        public InyoPoolsDbContext(DbContextOptions<InyoPoolsDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories {get; set;}
        public DbSet<ProductCategory> ProductCategories { get; set;}

        public DbSet<ProductType> ProductTypes { get; set;} 
        public DbSet<TestCategory> TestCategories { get; set;}

        public DbSet<Manufacturer> Manufacturers { get; set;}

        public DbSet<EmailLog> emailLogs { get; set;}

        public DbSet<Customer> Customers { get; set;}

        public DbSet<EmailType> EmailTypes { get; set;}

        public DbSet<OrderFormHeader> OrdersFormHeader { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<TestCategory>()
       .Property(tc => tc.ParentID)
       .IsRequired(false);

            builder.Entity<TestCategory>()
               
        .HasOne(tc => tc.Parent)
        .WithMany(tc => tc.Children)
        .HasForeignKey(tc => tc.ParentID)
        .OnDelete(DeleteBehavior.NoAction);

            base.OnModelCreating(builder);
            SeedRoles(builder);

            






        }
        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData
                (
                new IdentityRole() { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole() { Name = "User", ConcurrencyStamp = "2", NormalizedName = "User" },
                new IdentityRole() { Name = "HR", ConcurrencyStamp = "3", NormalizedName = "HR" }
                );
        }
    }
}