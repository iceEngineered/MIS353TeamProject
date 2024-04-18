using Microsoft.EntityFrameworkCore;
using PuccioAPIs.Entities;
namespace PuccioAPIs.Data;

public class DbContextClass : DbContext
{
    public DbContextClass(DbContextOptions<DbContextClass> options)
        : base(options)
    {
    }
    public DbSet<Forecast> Forecast { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Forecast>()
            .HasKey(ndh => new { ndh.CID});
    }
}

