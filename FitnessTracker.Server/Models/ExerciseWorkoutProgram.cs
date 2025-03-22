using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Server.Models
{
    public class ExerciseWorkoutProgram
    {
        [Key]
        public int ExerciseWorkoutProgram_Id { get; set; }

        public int Exercise_Id { get; set; }
        public Exercise Exercise { get; set; }

        public int WorkoutProgram_Id { get; set; }
        public WorkoutProgram WorkoutProgram { get; set; }

        public ExerciseWorkoutProgram(int exercise_Id, int workoutProgram_Id)
        {
            Exercise_Id = exercise_Id;
            WorkoutProgram_Id = workoutProgram_Id;
        }

        public ExerciseWorkoutProgram() { }
    }
}
