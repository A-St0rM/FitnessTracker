using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Server.Models
{
    public class Exercise
    {

        [Key]
        public int Exercise_Id { get; set; }

        public string ExerciseName { get; set; }
        public int Set { get; set; }
        public int Repetitions { get; set; }

        public ICollection<ExerciseWorkoutProgram> ExerciseWorkoutPrograms { get; set; }

        public Exercise(string exerciseName, int set, int repetitions)
        {
            ExerciseName = exerciseName;
            Set = set;
            Repetitions = repetitions;
            ExerciseWorkoutPrograms = new List<ExerciseWorkoutProgram>();
        }

        public Exercise() { }

    }
}
