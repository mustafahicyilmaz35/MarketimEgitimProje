using Marketim.Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.DataAccess.Concretes.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CategoryName).HasColumnType("nvarchar(50)");
            builder.HasMany(x => x.Products).WithOne(y => y.Category).HasForeignKey(z=>z.CategoryId);
            
        }
    }
}
