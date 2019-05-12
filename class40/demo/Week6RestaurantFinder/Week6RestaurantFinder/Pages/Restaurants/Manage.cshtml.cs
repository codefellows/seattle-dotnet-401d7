using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.WindowsAzure.Storage.Blob;
using System.IO;
using System.Threading.Tasks;
using Week6RestaurantFinder.Models;
using Week6RestaurantFinder.Models.Interfaces;
using Week6RestaurantFinder.Models.Util;

namespace Week6RestaurantFinder.Pages.Restaurants
{
    public class ManageModel : PageModel
    {
        private readonly IRestaurant _restaurant;

        [FromRoute]
        public int? ID { get; set; }

        [BindProperty]
        public Restaurant Restaurant { get; set; }

        [BindProperty]
        public IFormFile Image { get; set; }

        public Blob BlobImage { get; set; }

        public ManageModel(IRestaurant restaurant, IConfiguration configuration)
        {
            _restaurant = restaurant;
            //Blob Storage Account to be referenced
            BlobImage = new Blob(configuration);
        }

        public async Task OnGet()
        {
            Restaurant = await _restaurant.FindRestaurant(ID.GetValueOrDefault()) ?? new Restaurant();
        }

        public async Task<IActionResult> OnPost()
        {
            // Make the call to our DB with our ID.
            Restaurant rest = await _restaurant.FindRestaurant(ID.GetValueOrDefault()) ?? new Restaurant();

            // set the data from the database to the new data from Restaurant/user input
            rest.Name = Restaurant.Name;
            rest.Description = Restaurant.Description;
            rest.StarRating = Restaurant.StarRating;

            if (Image != null)
            {
                // Do all of our Azure Blob stuffs
                var filePath = Path.GetTempFileName();

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await Image.CopyToAsync(stream);
                }

                // Get Container
                var container = await BlobImage.GetContainer("restaurant");

                // upload the image
                BlobImage.UploadFile(container, Image.FileName, filePath);

                //  Get the image that we just uploaded 
                CloudBlob blob = await BlobImage.GetBlob(Image.FileName, container.Name);

                // update the db image for the restaurant
                rest.URL = blob.Uri.ToString();


            }

            // Save the restaurant in the database
            await _restaurant.SaveAsync(rest);

            return RedirectToPage("/Restaurants/Index", new { id = rest.ID });
        }

        public async Task<IActionResult> OnPostDelete()
        {
            await _restaurant.DeleteAsync(ID.Value);
            return RedirectToPage("/Index");
        }
    }
}