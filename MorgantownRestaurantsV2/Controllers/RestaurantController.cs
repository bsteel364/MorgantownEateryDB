using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MorgantownRestaurantsV2.Models.RestaurantModel;
using MorgantownRestaurantsV2.ViewModels;

namespace MorgantownRestaurantsV2.Controllers
{
    public class RestaurantController : Controller
    {
        private IRestaurantRepo RestRepoInterface ;

        public RestaurantController(IRestaurantRepo RestRepo)
        {
            RestRepoInterface = RestRepo;
        }
        [HttpGet]
        public IActionResult SearchRestaurantsByType()
        {

            PopulateDropDownList();
            SearchTypeViewModel TypeModel = new SearchTypeViewModel();
            return View(TypeModel);
        }
        [HttpPost]
        public IActionResult SearchRestaurantsByType(SearchTypeViewModel Model)
        {

            PopulateDropDownList();




            Model = RestRepoInterface.SearchRestaurantsByType(Model);
            return View(Model);
        }
        public void PopulateDropDownList()
        {
            ViewData["TypeList"] = new SelectList(RestRepoInterface.ListTypes(), "FoodTypeID", "FoodTypeName");
            ViewData["PriceRangeList"] = new SelectList(RestRepoInterface.GetPriceRanges(), "PriceRangeID", "PriceRangeRating");

        }
    }
}