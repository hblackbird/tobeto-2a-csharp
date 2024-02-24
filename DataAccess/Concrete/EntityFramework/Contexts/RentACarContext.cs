using Core.Entities;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace DataAccess.Concrete.EntityFramework.Contexts;

public class RentACarContext : DbContext
{
    public DbSet<Brand> Brands { get; set; }
    public DbSet<Fuel> Fuels { get; set; }
    public DbSet<Transmission> Transmissions { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Model> Models { get; set; }
    public DbSet<Customers> Customers { get; set; }
    public DbSet<CorporateCustomer> CorporateCustomer { get; set; }
    public DbSet<IndividualCustomer> IndividualCustomer { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Roles> Roles { get; set; }
    public DbSet<UserRole> UserRoles { get; set; }

    public RentACarContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // İlişkileri tanımlamak için Fluent API kullanılır
        modelBuilder.Entity<UserRole>()
            .HasKey(ur => new { ur.UserId, ur.RoleId });

        modelBuilder.Entity<UserRole>()
            .HasOne(ur => ur.User)
            .WithMany(u => u.UserRoles)
            .HasForeignKey(ur => ur.UserId);

        modelBuilder.Entity<UserRole>()
            .HasOne(ur => ur.Role)
            .WithMany(r => r.UserRoles)
            .HasForeignKey(ur => ur.RoleId);

        // Diğer ilişki tanımlamaları buraya eklenir
    }

}