using FitnessTracker.Server.Database;
using FitnessTracker.Server.Models;
using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly FitnessTrackerDBContext _context;

        public LoginController(FitnessTrackerDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody] User user)
        {
            var userInDb = _context.users.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);
            if (userInDb == null)
            {
                return NotFound();
            }
            return Ok(userInDb);
        }

    }
}
