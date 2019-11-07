using Microsoft.EntityFrameworkCore;
using MorgantownRestaurantsV2.Data;
using MorgantownRestaurantsV2.Models.RestaurantModel;
using MorgantownRestaurantsV2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.Models.AreaModel
{
    public class AreaRepo : IAreaRepo
    {
        private ApplicationDbContext database;

        public AreaRepo(ApplicationDbContext dbContext)
        {
            database = dbContext;
        }

        public SearchAreaViewModel SearchRestaurantsByArea(SearchAreaViewModel model)
        {

            List<Restaurant> RestList
                 = database.Restaurants.Include(r => r.priceRange).Include(r => r.area).Include(r => r.deliveryService).ToList<Restaurant>();

            if (model.AreaID != null)
            {
                RestList = RestList
                     .Where(r => r.area.AreaID
                     == model.AreaID).ToList<Restaurant>();

            }
            if (model.DSID != null)
            {
                RestList = RestList.Where(r => r.deliveryService.DeliveryServiceID == model.DSID).ToList<Restaurant>();
            }
            

            model.RestList = RestList
                .ToList<Restaurant>();


            return model;




        }// end class

        public List<Area> GetAreas()
        {
            List<Area> AList = database.Areas.ToList<Area>();
            return AList;
        }
    }
}
