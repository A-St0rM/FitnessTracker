using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Server.Controllers
{
    public class WorkoutProgramController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
