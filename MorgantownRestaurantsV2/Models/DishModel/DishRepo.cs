using Microsoft.EntityFrameworkCore;
using MorgantownRestaurantsV2.Data;
using MorgantownRestaurantsV2.Models.Restaurant_DishModel;
using MorgantownRestaurantsV2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.Models.DishModel
{
    public class DishRepo : IDishRepo
    {
        private ApplicationDbContext database;

        public DishRepo(ApplicationDbContext dbContext)
        {
            database = dbContext;
        }
        public List<Dish> GetDishes()
        {
           List<Dish> dishes = database.Dishes.ToList<Dish>();
            return dishes;
        } 
        //public List<Restaurant_Dish> ViewDishes(int restID)
        //{

        //    List<Restaurant_Dish> Dishes = database.restaurant_Dishes.Include(d => d.Rest).Include(d => d.dish).Where(d => d.RestaurantID == restID).ToList<Restaurant_Dish>();
        //    ViewDishViewModel dishViewModel = new ViewDishViewModel();

        //    dishViewModel.RestID = restID;
        //    dishViewModel.dishList = Dishes;



        //    return Dishes;

        //}
    }
}
