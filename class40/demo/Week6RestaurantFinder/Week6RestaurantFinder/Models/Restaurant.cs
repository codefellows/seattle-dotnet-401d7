using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week6RestaurantFinder.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StarRating { get; set; }

        public string URL { get; set; }
    }
}
