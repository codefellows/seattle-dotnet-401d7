using CMSBlogPost.Models;
using CMSBlogPost.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace CMSBlogPost.Pages.Posts
{
    public class EditModel : PageModel
    {
        private IPosts _posts;
        [BindProperty]
        public Post Post { get; set; }

        [FromRoute]
        public int ID { get; set; }

        public EditModel(IPosts posts)
        {
            _posts = posts;
        }


        public void OnGet()
        {
            Post = _posts.GetPost(ID);
           
        }

        public async Task<IActionResult> OnPost()
        {
            Post existingPost = _posts.GetPost(ID);

            existingPost.Title = Post.Title;
            existingPost.Description = Post.Description;

            await _posts.UpdatePost(ID, existingPost);

            return RedirectToPage("AllPosts");
        }

        public async Task<IActionResult> OnPostDelete()
        {
            await _posts.DeletePost(ID);
            return RedirectToPage("/AllPosts");
        }
    }
}