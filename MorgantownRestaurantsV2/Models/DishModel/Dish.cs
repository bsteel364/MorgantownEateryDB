using MorgantownRestaurantsV2.Models.Restaurant_DishModel;
using MorgantownRestaurantsV2.Models.RestaurantModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.Models.DishModel
{
    public class Dish
    {
       [Key]
       public int DishID { get; set; }
       public string DishName { get; set; }
       public string DishDescription { get; set; }

        //[ForeignKey("Restaurant_DishID")]
        //public int Restaurant_DishID { get; set; }
        //[ForeignKey("RestaurantID")]
        //public int RestaurantID { get; set; }

       //List<Restaurant_Dish> Restaurants_DishList { get; set; }









    }
}
