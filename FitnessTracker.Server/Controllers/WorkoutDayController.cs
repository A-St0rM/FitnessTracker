using Microsoft.AspNetCore.Mvc;

namespace FitnessTracker.Server.Controllers
{
    public class WorkoutDayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
