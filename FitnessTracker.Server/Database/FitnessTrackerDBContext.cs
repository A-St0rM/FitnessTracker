using Microsoft.EntityFrameworkCore;
using FitnessTracker.Server.Models;

namespace FitnessTracker.Server.Database
{
    public class FitnessTrackerDBContext : DbContext
    {
        public FitnessTrackerDBContext(DbContextOptions<FitnessTrackerDBContext> options) : base(options)
        {

        }

        public DbSet<User> users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
