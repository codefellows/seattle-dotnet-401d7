using Microsoft.EntityFrameworkCore;
using Week6RestaurantFinder.Models;

namespace Week6RestaurantFinder.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant
                {
                    ID = 1,
                    Name = "Chace's Pancake Coral",
                    StarRating = 4,
                    URL = "chace.jpg"
                },
                new Restaurant
                {
                    ID = 2,
                    Name = "SmallCakes",
                    StarRating = 5,
                    URL = "cupcake.png"
                }


                );
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
