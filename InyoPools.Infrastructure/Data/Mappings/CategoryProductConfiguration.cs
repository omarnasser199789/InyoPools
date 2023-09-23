using InyoPools.Core.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Infrastructure.Data.Mappings
{
    public class CategoryProductConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(x => x.ID);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Description)
                .HasMaxLength(1000);

            builder.Property(x => x.ImagePath)
                .HasMaxLength(500);

            builder.Property(x => x.CategoryPage)
                .HasMaxLength(500);

            builder.Property(x => x.ImageName)
                .HasMaxLength(100);

            builder.Property(x => x.PageFooter)
                .HasMaxLength(500);

            builder.Property(x => x.PageHeader)
                .HasMaxLength(500);

            builder.Property(x => x.GoogleConversionLabel)
                .HasMaxLength(100);

            builder.Property(x => x.PageTitle)
                .HasMaxLength(200);

            builder.Property(x => x.PageDescription)
                .HasMaxLength(500);

            builder.Property(x => x.PageKeywords)
                .HasMaxLength(500);

            builder.Property(x => x.PageH1)
                .HasMaxLength(200);

            builder.Property(x => x.NavigationTitle)
                .HasMaxLength(200);

            builder.Property(x => x.NavigationAdvertisementHeading)
                .HasMaxLength(200);

            builder.Property(x => x.NavigationAdvertisementImagePath)
                .HasMaxLength(500);

            builder.Property(x => x.NavigationAdvertisementText)
                .HasMaxLength(1000);

            builder.HasOne(x => x.ParentCategory)
                .WithMany (
                m => m.Subcategories
                )
                .HasForeignKey(x => x.ParentID)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.HasMany(x => x.Subcategories).WithOne().HasForeignKey(x => x.ParentID);

            //builder.HasOne(x => x.ParentCategory).WithOne();


            //modelBuilder.Entity<Category>()
            //.HasOne(s => s.Parent)
            //.WithMany(m => m.Children)
            //.HasForeignKey(e => e.ParentId);


            //builder.HasOne(x => x.ParentCategory)
            //    .WithMany(m => m.Subcategories)
            //    .HasForeignKey(x => x.ParentID);








        }
    }
}
