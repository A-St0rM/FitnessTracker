using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Server.Models
{
    public class ExerciseWorkoutProgram
    {
        [Key]
        public int ExerciseWorkoutProgram_Id { get; set; }

        [Required]
        [ForeignKey("Exercise_Id")]
        public int Exercise_Id { get; set; }

        [Required]
        [ForeignKey("WorkoutProgram_Id")]
        public int WorkoutProgram_Id { get; set; }

        public ExerciseWorkoutProgram(int exercise_Id, int workoutProgram_Id)
        {
            this.Exercise_Id = exercise_Id;
            this.WorkoutProgram_Id = workoutProgram_Id;
        }

        public ExerciseWorkoutProgram()
        {
        }

    }
}
