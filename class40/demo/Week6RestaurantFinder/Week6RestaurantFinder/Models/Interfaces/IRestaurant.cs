using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week6RestaurantFinder.Models.Interfaces
{
    public interface IRestaurant
    {
        // Delete
        Task DeleteAsync(int id);
        // Find
        Task<Restaurant> FindRestaurant(int id);

        // GetAll
        Task<List<Restaurant>> GetRestaurants();

        // Save
        Task SaveAsync(Restaurant restaurant);
    }
}
