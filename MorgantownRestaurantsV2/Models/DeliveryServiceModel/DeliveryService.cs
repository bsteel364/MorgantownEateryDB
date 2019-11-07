using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.Models.DeliveryServiceModel
{
    public class DeliveryService
    {
        [Key]
        public int DeliveryServiceID { get; set; }
        public string DeliveryServiceName { get; set; }
        public string DeliveryServiceType { get; set; }
        public double DeliveryFee { get; set; }
    }
}
