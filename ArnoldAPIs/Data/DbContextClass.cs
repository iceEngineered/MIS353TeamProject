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

        /*since the NaturalDisasterHistory table has a composite key (otherwise a city or date wouldn't be able to have multiple disasters stored)
        I had to use ChatGPT to fix this after getting an error (some variable names were changed after the prompt was given)

       Prompt 1:  System.InvalidOperationException: 'The entity type 'NaturalDisasterHistory' has multiple properties with the [Key] attribute. Composite primary keys configured by placing the [PrimaryKey] attribute on the entity type class, or by using 'HasKey' in 'OnModelCreating'.'          
        
        Prompt 2: I want DateOccured to also be part of the key

        That output the protected override

        */
    }
}


