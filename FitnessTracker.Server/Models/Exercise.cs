using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Server.Models
{
    public class Exercise
    {

        [Key]
        public int Exercise_Id { get; set; }

        [Required]
        public string ExerciseName { get; set; }

        [Required]
        public int Set { get; set; }

        [Required]
        public int Repetitions { get; set; }

        public ExerciseWorkoutProgram ExerciseWorkoutProgram { get; set; }

        public Exercise(string exerciseName, int set, int repetitions)
        {
            this.ExerciseName = exerciseName;
            this.Set = set;
            this.Repetitions = repetitions;
        }

        public Exercise()
        {
        }

    }
}
