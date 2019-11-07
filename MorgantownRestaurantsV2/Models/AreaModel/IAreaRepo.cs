using MorgantownRestaurantsV2.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.Models.AreaModel
{
    public interface IAreaRepo
    {
        List<Area> GetAreas();

        SearchAreaViewModel SearchRestaurantsByArea(SearchAreaViewModel model);
    }
}
