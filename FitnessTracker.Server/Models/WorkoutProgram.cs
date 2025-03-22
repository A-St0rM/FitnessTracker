using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Server.Models
{
    public class WorkoutProgram
    {
        [Key]
        public int WorkoutProgram_Id { get; set; }

        [Required]
        public string ProgramName { get; set; }

        public ICollection<WorkoutDay> WorkoutDays { get; set; }
        public ICollection<ExerciseWorkoutProgram> ExerciseWorkoutPrograms { get; set; }

        public WorkoutProgram(string programName)
        {
            ProgramName = programName;
            WorkoutDays = new List<WorkoutDay>();
            ExerciseWorkoutPrograms = new List<ExerciseWorkoutProgram>();
        }

        public WorkoutProgram() { }
    }
}
