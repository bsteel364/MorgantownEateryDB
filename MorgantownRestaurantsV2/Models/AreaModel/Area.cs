using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.Models
{
    public class Area
    {
        [Key]
        public int AreaID { get; set; }
        public string AreaName { get; set; }

    }
}
