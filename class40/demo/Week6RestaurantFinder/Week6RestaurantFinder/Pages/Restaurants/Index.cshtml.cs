using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Week6RestaurantFinder.Models;
using Week6RestaurantFinder.Models.Interfaces;

namespace Week6RestaurantFinder.Pages.Restaurants
{
    public class IndexModel : PageModel
    {
        private readonly IRestaurant _restaurant;

        public IndexModel(IRestaurant restaurant)
        {
            _restaurant = restaurant;
        }

        [FromRoute]
        public int ID { get; set; }
        public Restaurant Restaurant { get; set; }

        public async Task OnGet()
        {
            // set all the data for my .cshtml page.

            // Get the specific Restaurant data for the id that was sent. 
            Restaurant = await _restaurant.FindRestaurant(ID);
        }
    }
}