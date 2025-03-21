using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Server.Models
{
    public class WorkoutProgram
    {
        [Key]
        public int WorkoutProgram_Id { get; set; }

        [ForeignKey("ExerciseWorkoutProgram_Id")]
        public int ExerciseWorkoutProgram_Id { get; set; }

        [Required]
        public string ProgramName { get; set; }

        [Required]
        public List<Exercise> Exercises { get; set; }

        public ICollection<WorkoutDay> WorkoutDays { get; set; }

        public ExerciseWorkoutProgram ExerciseWorkoutProgram {get; set;}

        public WorkoutProgram(string programName, List<Exercise> exercises)
        {
            this.ProgramName = programName;
            this.Exercises = exercises;
            this.WorkoutDays = new List<WorkoutDay>();
        }
        public WorkoutProgram()
        {
        }
    }
}
