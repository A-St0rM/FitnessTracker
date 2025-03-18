using FitnessTracker.Server.Database;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExerciseController : ControllerBase
    {
        private readonly FitnessTrackerDBContext _context;

        public ExerciseController(FitnessTrackerDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("getExercises")]
        public IActionResult GetExercises() //TODO: Add logic
        {
            return Ok();
        }

        [HttpGet]
        [Route("getExercise/{id}")]
        public IActionResult GetExercise(int id) //TODO: Add logic
        {
            return Ok();
        }



        [HttpPut]
        [Route("addExercise")]
        public IActionResult AddExercise() //TODO: Add logic
        {
            return Ok();
        }

        [HttpPost]
        [Route("updateExercise")]
        public IActionResult UpdateExercise() //TODO: Add logic
        {
            return Ok();
        }


        [HttpDelete]
        [Route("deleteExercise")]
        public IActionResult DeleteExercise(int id) //TODO: Add logic
        {
            return Ok();
        }


        
    }
}
