using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Server.Models
{
    public class ExerciseWorkoutProgram
    {
        [Key]
        public int ExerciseWorkoutProgram_Id { get; set; }

        // Foreign Key to Exercise
        public int Exercise_Id { get; set; }
        public Exercise Exercise { get; set; }

        // Foreign Key to WorkoutProgram
        public int WorkoutProgram_Id { get; set; }
        public WorkoutProgram WorkoutProgram { get; set; }

        public ICollection<Exercise> Exercises { get; set; }

        public ICollection<WorkoutProgram> WorkoutPrograms { get; set; }

        public ExerciseWorkoutProgram(int exercise_Id, int workoutProgram_Id)
        {
            this.Exercise_Id = exercise_Id;
            this.WorkoutProgram_Id = workoutProgram_Id;
            this.Exercises = new List<Exercise>();
            this.WorkoutPrograms = new List<WorkoutProgram>();
        }

        public ExerciseWorkoutProgram() { }
    }
}
