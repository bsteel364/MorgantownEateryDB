using MorgantownRestaurantsV2.Models.RestaurantModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.Models.FoodTypeModel
{
    public class FoodType
    {
        [Key]
        public int FoodTypeID { get; set; }
        public string FoodTypeName { get; set; }

        public List<Restaurant> Restaurants { get; set; }

    }
}
