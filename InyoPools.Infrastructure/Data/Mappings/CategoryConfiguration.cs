using InyoPools.Core.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyoPools.Infrastructure.Data.Mappings
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //builder.ToTable("CDS_OrderAlerts");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsActive);
            builder.Property(x => x.PerentLevel);
            builder.Property(x => x.PerentId);
            builder.Property(x => x.Name);
            builder.Property(x => x.Description);
            builder.Property(x => x.ImagePath);
            //builder.Ignore(x => x.OrderAlertType);
            //builder.HasOne(x => x.Order).WithMany(x => x.OrderAlerts).HasForeignKey(x => x.OrderHeaderNumber);
            //builder.HasOne(x => x.OrderSummary).WithMany(x => x.OrderAlerts).HasForeignKey(x => x.OrderHeaderNumber);
        }




    }
}
