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
        public DbSet<WorkoutDay> workoutDays { get; set; }
        public DbSet<WorkoutProgram> workoutPrograms { get; set; }
        public DbSet<Exercise> exercises { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
