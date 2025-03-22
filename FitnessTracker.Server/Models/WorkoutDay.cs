using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Server.Models
{
    public class WorkoutDay
    {
        [Key]
        public int WorkoutDay_Id { get; set; }

        public int WorkoutProgram_Id { get; set; }
        public WorkoutProgram WorkoutProgram { get; set; }

        [Required]
        public DateOnly Date { get; set; }

        public WorkoutDay(DateOnly date, WorkoutProgram workoutProgram)
        {
            Date = date;
            WorkoutProgram = workoutProgram;
            WorkoutProgram_Id = workoutProgram.WorkoutProgram_Id;
        }

        public WorkoutDay() { }
    }
}
