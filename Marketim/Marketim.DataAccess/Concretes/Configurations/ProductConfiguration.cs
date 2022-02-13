using Marketim.Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.DataAccess.Concretes.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProductName).HasColumnType("nvarchar(50)");
            builder.Property(x => x.StockCount).HasColumnType("int");
            builder.Property(x => x.UnitPrice).HasColumnType("money");
        }
    }
}
