using Microsoft.EntityFrameworkCore;
using MISTeamProjectAPI.Entities;
namespace MISTeamProjectAPI.Data;

public class DbContextClass : DbContext
{
    public DbContextClass(DbContextOptions<DbContextClass> options)
        : base(options)
    {
    }
    public DbSet<Disaster> Disaster { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Disaster>()
            .HasKey(ndh => new { ndh.CID, ndh.NDDate });
    }
}


