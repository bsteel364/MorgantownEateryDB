using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using MorgantownRestaurantsV2.Data;
using MorgantownRestaurantsV2.Models.DeliveryServiceModel;
using MorgantownRestaurantsV2.Models.DishModel;
using MorgantownRestaurantsV2.Models.FoodTypeModel;
using MorgantownRestaurantsV2.Models.Restaurant_DishModel;

namespace MorgantownRestaurantsV2.Models.RestaurantModel
{
    public class Restaurant
    {
        [Key]
        public int RestaurantID { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantAddress { get; set; }
        
        public string RestaurantOwner { get; set; }
        
        [ForeignKey("FoodTypeID")]
        public int FoodTypeID { get; set; }
        [ForeignKey("PriceRangeID")]
        public int PriceRangeID { get; set; }
        [ForeignKey("AreaID")]
        public int AreaID { get; set; }
        [ForeignKey("DeliveryServiceID")]
        public int DeliveryServiceID { get; set; }
        

        public DeliveryService deliveryService { get; set; }

        public Area area { get; set; }

        public PriceRange priceRange { get; set; }

        public FoodType foodType { get; set; }

        List<Restaurant_Dish> Restaurants_DishList { get; set; }

        //public List<Dish> dishList { get; set; }



        //public bool? isVegan { get; set; }




    }
}
