using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MorgantownRestaurantsV2.Models;
using MorgantownRestaurantsV2.Models.DeliveryServiceModel;
using MorgantownRestaurantsV2.Models.DishModel;
using MorgantownRestaurantsV2.Models.FoodTypeModel;
using MorgantownRestaurantsV2.Models.Restaurant_DishModel;
using MorgantownRestaurantsV2.Models.RestaurantModel;

namespace MorgantownRestaurantsV2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
            public DbSet<ApplicationUser> ApplicationUsers { get; set; }
            public DbSet<Restaurant> Restaurants { get; set; }
            public DbSet<FoodType> FoodTypes { get; set; }
            public DbSet<PriceRange> PriceRanges { get; set; }
            public DbSet<Area> Areas { get; set; }
            public DbSet<DeliveryService> DeliveryServices { get; set; }
            public DbSet<Dish> Dishes { get; set; }
            public DbSet<Restaurant_Dish> restaurant_Dishes { get; set; }
    }
    
    
}
