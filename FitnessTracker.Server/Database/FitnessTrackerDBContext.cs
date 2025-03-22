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
            // WorkoutDay → WorkoutProgram
            modelBuilder.Entity<WorkoutDay>()
                .HasOne(wd => wd.WorkoutProgram)
                .WithMany(wp => wp.WorkoutDays)
                .HasForeignKey(wd => wd.WorkoutProgram_Id)
                .OnDelete(DeleteBehavior.Cascade);

            // ExerciseWorkoutProgram → Exercise
            modelBuilder.Entity<ExerciseWorkoutProgram>()
                .HasOne(ewp => ewp.Exercise)
                .WithMany(e => e.ExerciseWorkoutPrograms)
                .HasForeignKey(ewp => ewp.Exercise_Id)
                .OnDelete(DeleteBehavior.NoAction); // ✅ Dette er NØGLEN

            // ExerciseWorkoutProgram → WorkoutProgram
            modelBuilder.Entity<ExerciseWorkoutProgram>()
                .HasOne(ewp => ewp.WorkoutProgram)
                .WithMany(wp => wp.ExerciseWorkoutPrograms)
                .HasForeignKey(ewp => ewp.WorkoutProgram_Id)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
