using Marketim.DataAccess.Concretes.Configurations;
using Marketim.Entity.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marketim.DataAccess.Concretes.Contexts
{
    public class MarketimContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Marketim;Integrated Security=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new ManagerConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }

        DbSet<Category> Categories { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Manager> Managers { get; set; }
        DbSet<Product> Products { get; set; }
    }
}
