using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Server.Models
{
    public class WorkoutProgram
    {
        [Key]
        public int WorkoutProgram_Id { get; set; }

        [Required]
        public string ProgramName { get; set; }

        [Required]
        public List<Exercise> Exercises { get; set; }

        public WorkoutProgram(string programName, List<Exercise> exercises)
        {
            this.ProgramName = programName;
            this.Exercises = exercises;
        }
        public WorkoutProgram()
        {
        }
    }
}
