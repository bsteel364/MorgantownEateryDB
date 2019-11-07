using MorgantownRestaurantsV2.Models.RestaurantModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.ViewModels
{
    public class SearchTypeViewModel
    {
        public int? FoodTypeID { get; set; }

        public int? PriceRangeID { get; set; }

        public List<Restaurant> RestList {get; set;}
    }
}
