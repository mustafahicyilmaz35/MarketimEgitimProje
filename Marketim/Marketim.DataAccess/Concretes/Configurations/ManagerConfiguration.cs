using Marketim.Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.DataAccess.Concretes.Configurations
{
    class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(50)");
            builder.Property(x => x.Surname).HasColumnType("nvarchar(50)");
            builder.HasMany(x => x.Employees).WithOne(x => x.Manager).HasForeignKey(x=>x.ManagerId);
            
        }
    }
}
