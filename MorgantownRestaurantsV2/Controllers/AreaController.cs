using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MorgantownRestaurantsV2.Models;
using MorgantownRestaurantsV2.Models.AreaModel;
using MorgantownRestaurantsV2.Models.DeliveryServiceModel;
using MorgantownRestaurantsV2.Models.RestaurantModel;
using MorgantownRestaurantsV2.ViewModels;

namespace MorgantownRestaurantsV2.Controllers
{
    public class AreaController : Controller
    {
        private IAreaRepo AreaRepoInterface;
        private IRestaurantRepo RestaurantRepoInterface;
        private IDeliveryServiceRepo DeliveryServiceRepoInterface;

        public AreaController(IAreaRepo AreaRepo, IRestaurantRepo RestRepo, IDeliveryServiceRepo serviceRepo)
        {
            AreaRepoInterface = AreaRepo;
            RestaurantRepoInterface = RestRepo;
            DeliveryServiceRepoInterface = serviceRepo;
        }
        [HttpGet]
        public IActionResult SearchRestaurantsByArea()
        {

            PopulateDropDownList();
            SearchAreaViewModel Model = new SearchAreaViewModel();
            return View(Model);
        }
        [HttpPost]
        public IActionResult SearchRestaurantsByArea(SearchAreaViewModel Model)
        {

            PopulateDropDownList();




            Model = AreaRepoInterface.SearchRestaurantsByArea(Model);
            return View(Model);
        }
        public void PopulateDropDownList()
        {
           
            ViewData["AreaList"] = new SelectList(AreaRepoInterface.GetAreas(), "AreaID", "AreaName");
            ViewData["DSList"] = new SelectList(DeliveryServiceRepoInterface.GetDeliveryServices(), "DeliveryServiceID", "DeliveryServiceName");

        }
    }
}