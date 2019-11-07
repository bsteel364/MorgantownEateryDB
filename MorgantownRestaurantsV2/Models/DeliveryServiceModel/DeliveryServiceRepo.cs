using MorgantownRestaurantsV2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.Models.DeliveryServiceModel
{
    public class DeliveryServiceRepo : IDeliveryServiceRepo
    {
        private ApplicationDbContext database;

        public DeliveryServiceRepo(ApplicationDbContext dbContext)
        {
            database = dbContext;
        }

        public List<DeliveryService> GetDeliveryServices()
        {
            List<DeliveryService> DSList = database.DeliveryServices.ToList<DeliveryService>();
            return DSList;

        }
    }
    
}
