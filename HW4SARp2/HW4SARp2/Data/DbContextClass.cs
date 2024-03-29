using HW4SARp2.Entities;
using Microsoft.EntityFrameworkCore;

namespace HW4SARp2.Data
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> options): base(options)
        { }
        public DbSet<City> City { get; set; }
    }
}
