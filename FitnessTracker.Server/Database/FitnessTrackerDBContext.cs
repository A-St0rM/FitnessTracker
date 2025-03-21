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
        public DbSet<ExerciseWorkoutProgram> exerciseWorkoutPrograms { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WorkoutDay>()
                .HasOne(wd => wd.WorkoutProgram)
                .WithMany(wp => wp.WorkoutDays)
                .HasForeignKey(wd => wd.WorkoutProgram_Id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<WorkoutProgram>()
                .HasOne(wp => wp.ExerciseWorkoutProgram)
                .WithMany(ewp => ewp.WorkoutPrograms)
                .HasForeignKey(wp => wp.ExerciseWorkoutProgram_Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
