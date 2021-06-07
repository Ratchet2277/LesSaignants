using ExercicePairProgamming.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicePairProgamming.Dal
{
    public class SaignantsContext : DbContext
    {
        public DbSet<Beverage> Beverages { get; set; }
        public DbSet<Side> Sides { get; set; }
        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Menu> Menus { get; set; }

        public SaignantsContext() : base() { }

        public SaignantsContext(DbContextOptions options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=SaignantsDatabase;Integrated Security=true");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(p => p.Id);
            modelBuilder.Entity<Product>().Property(p => p.Id).UseIdentityColumn();
            modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Beverage>().HasMany(b => b.Menus).WithOne(m => m.Beverage);
            modelBuilder.Entity<Side>().HasMany(s => s.Menus).WithOne(m => m.Side);
            modelBuilder.Entity<Dessert>().HasMany(d => d.Menus).WithOne(m => m.Dessert);
            modelBuilder.Entity<Burger>().HasMany(b => b.Menus).WithOne(m => m.Burger);

            base.OnModelCreating(modelBuilder);
        }
    }
}
