using AutoService.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace AutoService.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<ClientEntity> Clients { get; set; }
        public DbSet<AddressEntity> Addresses { get; set; }
        public DbSet<DriverLicenseEntity> DriverLicenses { get; set; }
        public DbSet<TransportCategoryEntity> TransportCategories { get; set; }
        public DbSet<InspectionEntity> Inspections { get; set; }
        public DbSet<TransportEntity> Transport { get; set; }
        public DbSet<FuelEntity> Fuel { get; set; }
        public DbSet<TransportModelEntity> TransportModels { get; set; }
        public DbSet<TransportMakeEntity> TransportMakes { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().HasIndex(u => new { u.Login, u.TokenNumber }).IsUnique(true);
            modelBuilder.Entity<ClientEntity>().HasIndex(c => c.Email).IsUnique(true);
            modelBuilder.Entity<DriverLicenseEntity>().HasIndex(dl => dl.Number).IsUnique(true);
            modelBuilder.Entity<TransportCategoryEntity>().HasIndex(tc => tc.Name).IsUnique(true);
            modelBuilder.Entity<InspectionEntity>().HasIndex(i => i.Number).IsUnique(true);
            modelBuilder.Entity<TransportEntity>().HasIndex(t => t.Number).IsUnique(true);
            modelBuilder.Entity<FuelEntity>().HasIndex(f => f.Name).IsUnique(true);
            modelBuilder.Entity<TransportModelEntity>().HasIndex(tm => tm.Name).IsUnique(true);
            modelBuilder.Entity<TransportMakeEntity>().HasIndex(tm => tm.Name).IsUnique(true);
            base.OnModelCreating(modelBuilder);
        }
    }
}