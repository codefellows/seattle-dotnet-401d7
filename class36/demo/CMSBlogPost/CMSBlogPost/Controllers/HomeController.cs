using CMSBlogPost.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CMSBlogPost.Controllers
{
    public class HomeController : Controller
    {
        public IConfiguration Configuration { get; }

        public HomeController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(bool works = true)
        {
            Payment payment = new Payment(Configuration);
            string answer = payment.Run();

            if(answer == "OK")
            {
                return View();
            }

            return View();

        }
    }
}