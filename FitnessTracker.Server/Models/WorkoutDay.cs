using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FitnessTracker.Server.Models
{
    public class WorkoutDay
    {
        [Key]
        public int WorkoutDay_Id { get; set; }

        [ForeignKey("WorkoutProgram_Id")]
        [Required]
        public int WorkoutProgram_Id { get; set; }
        [Required]
        public DateOnly Date { get; set; }

        [Required]
        public WorkoutProgram WorkoutProgram { get; set; }

        public WorkoutDay(DateOnly date, WorkoutProgram workoutProgram)
        {
            this.Date = date;
            this.WorkoutProgram = workoutProgram;
        }

        public WorkoutDay()
        {
        }
    }
}
