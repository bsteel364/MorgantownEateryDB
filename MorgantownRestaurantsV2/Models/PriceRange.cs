using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.Models
{
    public class PriceRange
    {
        [Key]
        public int PriceRangeID { get; set; }
        public string PriceRangeRating { get; set; }
    }
}
