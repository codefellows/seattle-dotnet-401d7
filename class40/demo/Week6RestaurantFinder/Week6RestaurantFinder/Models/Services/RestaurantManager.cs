using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Week6RestaurantFinder.Data;
using Week6RestaurantFinder.Models.Interfaces;

namespace Week6RestaurantFinder.Models.Services
{
    public class RestaurantManager : IRestaurant
    {
        private readonly RestaurantDbContext _context;

        public RestaurantManager(RestaurantDbContext context)
        {
            _context = context;
        }
        public async Task DeleteAsync(int id)
        {
            Restaurant restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant != null)
            {
                _context.Remove(restaurant);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Restaurant> FindRestaurant(int id)
        {
            Restaurant restaurant = await _context.Restaurants.FirstOrDefaultAsync(rest => rest.ID == id);

            return restaurant;
        }

        public async Task<List<Restaurant>> GetRestaurants()
        {
            return await _context.Restaurants.ToListAsync();
        }

        public async Task SaveAsync(Restaurant restaurant)
        {
            // Are we createing one?
            // Find the restaurant in the database
            if (await _context.Restaurants.FirstOrDefaultAsync(m => m.ID == restaurant.ID) == null)
            {
                _context.Restaurants.Add(restaurant);
            }
            else
            {             
                // update the database with the new restaurant data
                _context.Restaurants.Update(restaurant);
            }
            // save the database
            await _context.SaveChangesAsync();
        }
    }
}
