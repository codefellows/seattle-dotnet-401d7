using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMSBlogPost.Models.Interfaces
{
    public interface IPosts
    {
        List<Post> GetPosts();
        Post GetPost(int id);

        Task UpdatePost(int Id, Post post);

        Task DeletePost(int id);

        Task AddPost(Post post);
    }
}
