using Microsoft.EntityFrameworkCore;
using Backoffice.Models;

namespace Backoffice
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Courses> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Courses>().Property(c => c.Price).HasColumnType("decimal(18,2)");
        }
    }
}
