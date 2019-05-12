using CMSBlogPost.Models;
using CMSBlogPost.Models.Interfaces;
using CMSBlogPost.Models.Utilities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage.Blob;
using System.IO;
using System.Threading.Tasks;

namespace CMSBlogPost.Pages.Posts
{
    public class CreatePostModel : PageModel
    {
        private readonly IPosts _posts;

        [BindProperty]
        public Post Post { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        public Blob BlobImage { get; set; }

        public CreatePostModel(IPosts post, IConfiguration configuration)
        {
            _posts = post;
            // Blob Storage Account to use in page
            BlobImage = new Blob(configuration);
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            // Check if URL/Image is in the expected state (such as, it exists)
            if (Image != null)
            {
                // get a temp location on your server to store the file.
                // If you want to set a specific location, look back at Lab 11.
                var filePath = Path.GetTempFileName();

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await Image.CopyToAsync(stream);
                }

                var container = await BlobImage.GetContainer("posts");
                // upload the image
                BlobImage.UploadFile(container, Image.FileName, filePath);

                CloudBlob blob = await BlobImage.GetBlob(Image.FileName, container.Name);

                Post.URL = blob.Uri.ToString();

            }
            await _posts.AddPost(Post);
            return RedirectToPage("Index");
        }
    }
}