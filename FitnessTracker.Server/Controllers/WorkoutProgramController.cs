using FitnessTracker.Server.Database;
using FitnessTracker.Server.DTO;
using FitnessTracker.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Server.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class WorkoutProgramController : ControllerBase
    {
        private readonly FitnessTrackerDBContext _context;

        public WorkoutProgramController(FitnessTrackerDBContext _context)
        {
            this._context = _context;
        }


        [HttpGet]
        [Route("getWorkoutPorgrams")]
        public IActionResult GetWorkoutPrograms()
        {
            var workoutPrograms = _context.workoutPrograms.ToList();

            if(workoutPrograms == null)
            {
                return NotFound();
            }

            return Ok(workoutPrograms);
        }


        [HttpGet]
        [Route("getWorkoutPorgram")]
        public IActionResult GetWorkoutProgram(int id)
        {
            var workoutProgram = _context.workoutPrograms.FirstOrDefault(w => w.WorkoutProgram_Id == id);

            if(workoutProgram == null)
            {
                return NotFound();
            }

            return Ok(workoutProgram);
        }

        [HttpPut]
        [Route("updateWorkoutPorgrams")]
        public IActionResult UpdateWorkoutPrograms([FromBody] WorkoutProgram workoutProgram)
        {

            if (workoutProgram == null)
            {
                return BadRequest();
            }

            var updatedWorkoutProgram = _context.workoutPrograms.FirstOrDefault(w => w.WorkoutProgram_Id == workoutProgram.WorkoutProgram_Id);

            if(updatedWorkoutProgram == null)
            {
                return NotFound();
            }

            updatedWorkoutProgram.ProgramName = workoutProgram.ProgramName;

            _context.workoutPrograms.Update(updatedWorkoutProgram);
            _context.SaveChanges();


            return Ok(updatedWorkoutProgram);
        }


        [HttpPost]
        [Route("addWorkoutPorgrams")]
        public IActionResult AddWorkoutPrograms([FromBody] WorkoutProgramDTO workoutProgramDTO)
        {

            if(workoutProgramDTO == null)
            {
                return BadRequest();
            }


            var workoutProgram = new WorkoutProgram
            {
                ProgramName = workoutProgramDTO.ProgramName
            };

            _context.workoutPrograms.Add(workoutProgram);
            _context.SaveChanges();


            return CreatedAtAction(nameof(GetWorkoutProgram), new { id = workoutProgram.WorkoutProgram_Id }, workoutProgram);
        }


        [HttpDelete]
        [Route("deleteWorkoutPorgrams")]
        public IActionResult DeleteWorkoutPrograms(int id)
        {
            var workoutPrograms = _context.workoutPrograms.FirstOrDefault(w => w.WorkoutProgram_Id == id);

            if (workoutPrograms == null)
            {
                return NotFound();
            }


            _context.workoutPrograms.Remove(workoutPrograms);
            _context.SaveChanges();

            return NoContent();
        }


    }
}
