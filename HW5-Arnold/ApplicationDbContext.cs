using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MISTeamProjectAPI.Entities;


namespace MISTeamProject.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MISTeamProjectAPI.Entities.Disaster> Disaster { get; set; } = default!;
      
    }
}