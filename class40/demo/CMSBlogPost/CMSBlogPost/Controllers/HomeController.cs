using CMSBlogPost.Models;
using CMSBlogPost.Models.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Index(bool works = true)
        {
            //Payment payment = new Payment(Configuration);
            //string answer = payment.Run();

            //if(answer == "OK")
            //{
            //    return View();
            //}

            Blob blob = new Blob(Configuration);
            //await blob.GetContainer("dotnetcontainer");
           CloudBlob blobImage =  await blob.GetBlob("userstories.jpg", "myfirstcontainer");

            var image = blobImage.Uri;

            return View();

        }
    }
}