using CMSBlogPost.Data;
using CMSBlogPost.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSBlogPost.Models.Services
{
    public class PostsService : IPosts
    {
        private BlogDbContext _context;

        public PostsService(BlogDbContext context)
        {
            _context = context;
        }

        public async Task AddPost(Post post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePost(int id)
        {
            Post post = _context.Posts.FirstOrDefault(p => p.ID == id);
            _context.Posts.Remove(post);
           await _context.SaveChangesAsync();
        }

        public Post GetPost(int id)
        {
           return _context.Posts.FirstOrDefault(p => p.ID == id);
        }

        public List<Post> GetPosts()
        {
            return _context.Posts.ToList();
        }

        public async Task UpdatePost(int Id, Post post)
        {
          if(Id == post.ID)
            {
                _context.Update(post);
               await _context.SaveChangesAsync();
            }
          
        }
    }
}
