using FitnessTracker.Server.Database;
using FitnessTracker.Server.DTO;
using FitnessTracker.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WorkoutDayController : ControllerBase
    {

        private readonly FitnessTrackerDBContext _context;

        public WorkoutDayController(FitnessTrackerDBContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("getWorkoutDays")]
        public IActionResult GetWorkoutDays()
        {
            var workoutDays = _context.workoutDays.ToList();
            return Ok(workoutDays);
        }


        [HttpGet]
        [Route("getWorkoutDay")]
        public IActionResult GetWorkoutDay(int id)
        {
            var specificWorkoutDay = _context.workoutDays.FirstOrDefault(w => w.WorkoutDay_Id == id);
            if (specificWorkoutDay == null)
            {
                return NotFound();
            }
            return Ok(specificWorkoutDay);
        }

        [HttpPost]
        [Route("getWorkoutDay")]
        public IActionResult AddWorkoutDay([FromBody] WorkoutDayDTO workoutDayDTO)
        {

            if (workoutDayDTO == null)
            {
                return BadRequest();
            }

            var workoutDay = new WorkoutDay
            {
                Date = DateOnly.FromDateTime(workoutDayDTO.Date)
            };

            _context.workoutDays.Add(workoutDay);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetWorkoutDay), new { id = workoutDay.WorkoutDay_Id }, workoutDay);
        }



        [HttpPut]
        [Route("UpdateWorkoutDay")]
        public IActionResult getWorkoutDays()
        {
            var workoutDays = _context.workoutDays.ToList();
            return Ok(workoutDays);
        }

    }
}
