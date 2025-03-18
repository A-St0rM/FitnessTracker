using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Server.Models
{
    public class Exercise
    {

        [Key]
        public int Exercise_Id { get; set; }
        public string ExerciseName { get; set; }
        public int Set { get; set; }
        public int Repetitions { get; set; }

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
