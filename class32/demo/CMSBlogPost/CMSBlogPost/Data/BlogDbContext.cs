using CMSBlogPost.Models;
using Microsoft.EntityFrameworkCore;

namespace CMSBlogPost.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    ID = 1,
                    Title = "Tacos are Delicious",
                    Description = "They are the best!"
                },
                new Post
                {
                    ID = 2,
                    Title = "Josie Cat",
                    Description = "Josie is the queen of the household"
                },
                new Post
                {
                    ID = 3,
                    Title = "Belle Kitty",
                    Description = "Belle loves to lay around the house and meow"
                },
                new Post
                {
                    ID = 4,
                    Title = ".NET ROCKS",
                    Description = ".NET is the bestest of the best!! We all love to code in C#!!!!!"
                }
                );
        }

        public DbSet<Post> Posts { get; set; }
    }
}
