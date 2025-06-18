using Microsoft.AspNetCore.Mvc;

namespace RunningClube.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
