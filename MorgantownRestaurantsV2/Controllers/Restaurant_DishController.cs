using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MorgantownRestaurantsV2.Data;
using MorgantownRestaurantsV2.Models.DishModel;
using MorgantownRestaurantsV2.Models.Restaurant_DishModel;
using MorgantownRestaurantsV2.ViewModels;

namespace MorgantownRestaurantsV2.Controllers
{
    public class Restaurant_DishController : Controller
    {
        private ApplicationDbContext database;

        private IDishRepo dishRepoInterface;
        public Restaurant_DishController(IDishRepo dishRepo, ApplicationDbContext dbContext)
        {
            dishRepoInterface = dishRepo;
            database = dbContext;
        }
        //public IActionResult ViewDishes(int restID)
        //{
        //    ViewDishViewModel Model = new ViewDishViewModel();
        //    Model.RestID = restID;
        //    List<Restaurant_Dish> DishList = database.Dishes.Include(r => r).Include(.Include(d => d.Rest.deliveryService);
        //    //if (restID == 1)
        //    //{
        //    //    DishList = database.restaurant_Dishes.Include(r => r.Rest).Include(t => t.dish).Include(d => d.Rest.deliveryService).Where(r => r.RestaurantID == Model).ToList<Restaurant_Dish>();
        //    //}
        //    //if (restID == 2) { 
        //    //DishList = database.restaurant_Dishes.Include(r => r.Rest).Include(t => t.dish).Include(d => d.Rest.deliveryService).Where(r => r.RestaurantID == 2).ToList<Restaurant_Dish>();
        //    //}
        //    //List<Restaurant_Dish> DishList = database.restaurant_Dishes.Include(r => r.Rest).Include(t => t.dish).Include(d => d.Rest.deliveryService).Where(r => r.RestaurantID == Model.RestID).ToList<Restaurant_Dish>();
        //    //TransactionList.
        //    Model.dishList = DishList;
        //    return View(Model);







            

        //}
    }
}