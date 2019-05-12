using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMSBlogPost.Models;
using CMSBlogPost.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CMSBlogPost.Pages.Posts
{
    public class DetailsModel : PageModel
    {
        private IPosts _posts;

        public DetailsModel(IPosts post)
        {
            _posts = post;
        }
        [FromRoute]
        public int ID { get; set; }

        public Post Post { get; set; }
        public void OnGet()
        {
            Post = _posts.GetPost(ID);
        }
    }
}