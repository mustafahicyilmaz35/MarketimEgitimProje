using Marketim.Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.DataAccess.Concretes.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasColumnType("nvarchar(50)");
            builder.Property(x => x.Surname).HasColumnType("nvarchar(30)");
            builder.HasOne(x => x.Manager).WithMany(x => x.Employees).HasForeignKey(x => x.ManagerId);

        }
    }
}
