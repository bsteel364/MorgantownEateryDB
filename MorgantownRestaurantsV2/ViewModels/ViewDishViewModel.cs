using MorgantownRestaurantsV2.Models.Restaurant_DishModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.ViewModels
{
    public class ViewDishViewModel
    {
        public int RestID { get; set; }
        public int DishID { get; set; }
        public List<Restaurant_Dish> dishList { get; set; }

    }
}
