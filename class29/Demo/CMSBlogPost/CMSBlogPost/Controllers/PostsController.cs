using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CMSBlogPost.Controllers
{
    
    [Authorize(Policy ="Over18")]
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Posts()
        {
            return View();
        }
    }
}