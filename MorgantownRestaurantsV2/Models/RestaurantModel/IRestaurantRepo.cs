using MorgantownRestaurantsV2.Models.FoodTypeModel;
using MorgantownRestaurantsV2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.Models.RestaurantModel
{
    public interface IRestaurantRepo
    {
        IQueryable<Restaurant> GetRestaurants();
        List<PriceRange> GetPriceRanges();
        SearchTypeViewModel SearchRestaurantsByType(SearchTypeViewModel model);
        List<FoodType> ListTypes();
        List<string> GetRanges();
    }
}
