using Microsoft.AspNetCore.Mvc;

namespace Class13IntroToEFCore.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
