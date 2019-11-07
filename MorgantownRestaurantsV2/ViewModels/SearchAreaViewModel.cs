using MorgantownRestaurantsV2.Models.RestaurantModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.ViewModels
{
    public class SearchAreaViewModel
    {
        public int? AreaID { get; set; }
        public int? DSID { get; set; }

        public List<Restaurant> RestList { get; set; }
    }
}
