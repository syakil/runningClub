using Microsoft.AspNetCore.Mvc;

namespace RunningClube.Controllers
{
    public class ClubController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
