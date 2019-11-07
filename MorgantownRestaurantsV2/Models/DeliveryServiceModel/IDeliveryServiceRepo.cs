using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.Models.DeliveryServiceModel
{
    public interface IDeliveryServiceRepo
    {
        List<DeliveryService> GetDeliveryServices();
    }
}
