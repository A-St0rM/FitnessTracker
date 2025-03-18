using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Server.Models
{
    public class WorkoutDay
    {
        [Key]
        public int WorkoutDay_Id { get; set; }
        public DateOnly Date { get; set; }
        
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
