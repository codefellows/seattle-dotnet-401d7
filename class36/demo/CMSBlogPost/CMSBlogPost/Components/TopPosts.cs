using CMSBlogPost.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSBlogPost.Components
{
  //  [ViewComponent]
    public class TopPosts : ViewComponent
    {
        private BlogDbContext _context;

        public TopPosts(BlogDbContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync(int number)
        {
            var posts = await _context.Posts.OrderByDescending(x => x.ID)
                                      .Take(number)
                                      .ToListAsync();
            return View(posts);
        }
    }
}
