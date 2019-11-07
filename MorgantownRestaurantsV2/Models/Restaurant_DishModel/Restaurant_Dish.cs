using MorgantownRestaurantsV2.Models.DishModel;
using MorgantownRestaurantsV2.Models.RestaurantModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.Models.Restaurant_DishModel
{
    public class Restaurant_Dish
    {
        [Key]
        public int Restaurant_DishID { get; set; }
        [ForeignKey("RestaurantID")]
        public int RestaurantID { get; set; }
        [ForeignKey("DishID")]
        public int DishID { get; set; }

        public Dish dish { get; set; }
        public Restaurant Rest { get; set; }
        //public List<Dish> dishList { get; set; }
        
    }
}
