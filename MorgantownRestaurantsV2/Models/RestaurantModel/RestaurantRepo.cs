using Microsoft.EntityFrameworkCore;
using MorgantownRestaurantsV2.Data;
using MorgantownRestaurantsV2.Models.FoodTypeModel;
using MorgantownRestaurantsV2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.Models.RestaurantModel
{
    public class RestaurantRepo : IRestaurantRepo
    {
        private ApplicationDbContext database;

        public RestaurantRepo(ApplicationDbContext dbContext)
        {
            database = dbContext;
        }

        public SearchTypeViewModel SearchRestaurantsByType(SearchTypeViewModel model)
        {

            List<Restaurant> RestList
                 = database.Restaurants.Include(r => r.priceRange).Include(r => r.deliveryService).ToList<Restaurant>();

            if (model.FoodTypeID != null)
            {
                RestList = RestList
                     .Where(r => r.FoodTypeID
                     == model.FoodTypeID).ToList<Restaurant>();

            }
            if (model.PriceRangeID != null)
            {
                RestList = RestList
                     .Where(v => v.priceRange.PriceRangeID
                     == model.PriceRangeID).ToList<Restaurant>();

            }

            model.RestList = RestList
                .ToList<Restaurant>();


            return model;




        }// end class
        public IQueryable<Restaurant> GetRestaurants()
        {
            //List<Restaurant> RestList
            //   = database.Restaurants.Where(r => r.FoodTypeID == foodTypeID).ToList<Restaurant>();
            IQueryable<Restaurant> RestList = database.Restaurants;

            return RestList;

        }

        public List<FoodType> ListTypes()
        {
            List<FoodType> Types = database.FoodTypes.ToList<FoodType>();
            return Types;
        }

        public List<string> GetRanges()
        {
        List<string> Ranges = new List<string>();
        List<Restaurant> Restaurants = database.Restaurants.ToList<Restaurant>();
        
        for(int i = 0; i < Restaurants.Count(); i++)
            {
                Ranges[i] = Restaurants[i].priceRange.PriceRangeRating;
            }
        
        return Ranges;
       }
        public List<PriceRange> GetPriceRanges()
        {
            List<PriceRange> PRs = database.PriceRanges.ToList<PriceRange>();
            return PRs; 
        }
    }
}
