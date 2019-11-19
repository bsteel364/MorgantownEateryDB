using IronPython.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MorgantownRestaurantsV2.Models;
using MorgantownRestaurantsV2.Models.DeliveryServiceModel;
using MorgantownRestaurantsV2.Models.DishModel;
using MorgantownRestaurantsV2.Models.FoodTypeModel;
using MorgantownRestaurantsV2.Models.Restaurant_DishModel;
using MorgantownRestaurantsV2.Models.RestaurantModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MorgantownRestaurantsV2.Data
{
    public class DbInitializer
    {
        

        public static async Task Initialize(IServiceProvider services)
        {
            
            ApplicationDbContext database = services.GetRequiredService<ApplicationDbContext>();
            UserManager<ApplicationUser> userManager
                = services.GetRequiredService<UserManager<ApplicationUser>>();
            RoleManager<IdentityRole> roleManager
                = services.GetRequiredService<RoleManager<IdentityRole>>();

            string roleOfficial = "Official";
            
            if (!database.Roles.Any())
            {
                IdentityRole role = new IdentityRole(roleOfficial);

                await roleManager.CreateAsync(role);

            }
            if (!database.ApplicationUsers.Any())
            {

                ApplicationUser applicationUser =
                    new ApplicationUser("Test", "Official1", "TestOfficial1@wvu.edu", "304-000-0001", "TestOfficial1");
                await userManager.CreateAsync(applicationUser);
                await userManager.AddToRoleAsync(applicationUser, roleOfficial);

                //applicationUser = new ApplicationUser("Test", "Official2", "TestOfficial2@wvu.edu", "304-000-0002", "TestOfficial2");
                //await userManager.CreateAsync(applicationUser);
                //await userManager.AddToRoleAsync(applicationUser, roleOfficial);





            }
            if (!database.FoodTypes.Any())
            {
                FoodType FT = new FoodType
                {
                    FoodTypeName = "Mexican"
                   
                };
                database.FoodTypes.Add(FT);
                FT = new FoodType
                {
                    FoodTypeName = "Chinese"
                };
                database.FoodTypes.Add(FT);
                FT = new FoodType
                {
                    FoodTypeName = "American Fast Food"
                };
                database.FoodTypes.Add(FT);
                FT = new FoodType
                {
                    FoodTypeName = "Italian/Pizza"
                };
                database.FoodTypes.Add(FT);
                FT = new FoodType
                {
                    FoodTypeName = "Greek"
                };
                database.FoodTypes.Add(FT);
                FT = new FoodType
                {
                    FoodTypeName = "Steakhouse"
                };
                database.FoodTypes.Add(FT);
                FT = new FoodType
                {
                    FoodTypeName = "Cafe"
                };
                database.FoodTypes.Add(FT);
                FT = new FoodType
                {
                    FoodTypeName = "Buffet"
                };
                database.FoodTypes.Add(FT);
                FT = new FoodType
                {
                    FoodTypeName = "Bar/Pub"
                };
                database.FoodTypes.Add(FT);
                FT = new FoodType
                {
                    FoodTypeName = "Fine Dining"
                };
                database.FoodTypes.Add(FT);
                FT = new FoodType
                {
                    FoodTypeName = "American Sit Down"
                };
                database.FoodTypes.Add(FT);

                database.SaveChanges();
            }
            if (!database.PriceRanges.Any())
            {
                PriceRange PR = new PriceRange
                {
                    PriceRangeRating = "$"
                };
                database.PriceRanges.Add(PR);
                PR = new PriceRange
                {
                    PriceRangeRating = "$ $"
                };
                database.PriceRanges.Add(PR);
                PR = new PriceRange
                {
                    PriceRangeRating = "$ $ $"
                };
                database.PriceRanges.Add(PR);
                PR = new PriceRange
                {
                    PriceRangeRating = "$ $ $ $"
                };
                database.PriceRanges.Add(PR);
                PR = new PriceRange
                {
                    PriceRangeRating = "$ $ $ $ $"
                };
                database.PriceRanges.Add(PR);
                database.SaveChanges();

            }
            if (!database.Areas.Any())
            {
                Area A = new Area
                {
                    AreaName = "SunnySide"
                };
                database.Areas.Add(A);
                A = new Area
                {
                    AreaName = "Evansdale"
                };
                database.Areas.Add(A);
                A = new Area
                {
                    AreaName = "Downtown"
                };
                database.Areas.Add(A);
                database.SaveChanges();
            }
            if (!database.DeliveryServices.Any())
            {
                DeliveryService DS = new DeliveryService
                {
                    DeliveryServiceName = "No Service",
                    DeliveryServiceType = "None",
                    DeliveryFee = 0.0
                };
                database.DeliveryServices.Add(DS);
                DS = new DeliveryService
                {
                    DeliveryServiceName = "DoorDash",
                    DeliveryServiceType = "Drivers",
                    DeliveryFee = 5.99

                };
                database.DeliveryServices.Add(DS);
                DS = new DeliveryService
                {
                    DeliveryServiceName = "Papa Johns Delivery",
                    DeliveryServiceType = "Drivers",
                    DeliveryFee = 2.50

                };
                database.DeliveryServices.Add(DS);
                DS = new DeliveryService
                {
                    DeliveryServiceName = "Pizza Hut Delivery",
                    DeliveryServiceType = "Drivers",
                    DeliveryFee = 0.0

                };
                database.DeliveryServices.Add(DS);
                DS = new DeliveryService
                {
                    DeliveryServiceName = "GrubHub",
                    DeliveryServiceType = "Drivers",
                    DeliveryFee = 5.99

                };
                database.DeliveryServices.Add(DS);
                database.SaveChanges();

            }
            if (!database.Restaurants.Any())
            {
                Restaurant Rest = new Restaurant
                {
                    RestaurantName = "Chipotle",
                    RestaurantAddress = "17 Chaplin Road, Morgantown, WV 26501",
                    PriceRangeID = 2,
                    RestaurantOwner = null,
                    FoodTypeID = 1,
                    AreaID = 2,
                    DeliveryServiceID = 2



                };
                database.Restaurants.Add(Rest);
                Rest = new Restaurant
                {
                    RestaurantName = "Papa Johns",
                    RestaurantAddress = "229 Beechurst Ave, Morgantown, WV 26505",
                    PriceRangeID = 2,
                    RestaurantOwner = null,
                    FoodTypeID = 4,
                    AreaID = 1,
                    DeliveryServiceID = 3
                

                };
                database.Restaurants.Add(Rest);
                Rest = new Restaurant
                {
                    RestaurantName = "Pizza Hut",
                    RestaurantAddress = "374 Patteson Drive, Morgantown, WV 26505",
                    PriceRangeID = 1,
                    RestaurantOwner = null,
                    FoodTypeID = 4,
                    AreaID = 1,
                    DeliveryServiceID = 4
                    

                };
                database.Restaurants.Add(Rest);
                Rest = new Restaurant
                {
                    RestaurantName = "Texas Roadhouse",
                    RestaurantAddress = "3505 Monongahela Blvd, Star City, WV 26505",
                    PriceRangeID = 3,
                    RestaurantOwner = null,
                    FoodTypeID = 6,
                    AreaID = 2,
                    DeliveryServiceID = 1

                };
                database.Restaurants.Add(Rest);
                Rest = new Restaurant
                {
                    RestaurantName = "Taco Bell",
                    RestaurantAddress = "347 Patteson Drive, Morgantown, WV 26505",
                    PriceRangeID = 1,
                    RestaurantOwner = null,
                    FoodTypeID = 4,
                    AreaID = 2,
                    DeliveryServiceID = 5
               

                    

                };
                database.Restaurants.Add(Rest);
                Rest = new Restaurant
                {
                    RestaurantName = "Los Mariachis",
                    RestaurantAddress = "1137 Van Voorhis Rd, Morgantown, WV 26505",
                    PriceRangeID = 3,
                    RestaurantOwner = null,
                    FoodTypeID = 4,
                    AreaID = 2,
                    DeliveryServiceID = 2
                    

                };
                database.Restaurants.Add(Rest);
                Rest = new Restaurant
                {
                    RestaurantName = "Mountain State Brewing Co",
                    RestaurantAddress = "54 Clay St, Morgantown, WV 26501",
                    PriceRangeID = 3,
                    RestaurantOwner = null,
                    FoodTypeID = 9,
                    AreaID = 3,
                    DeliveryServiceID = 1
                    


                };
                database.Restaurants.Add(Rest);
                Rest = new Restaurant
                {
                    RestaurantName = "Morgantown Brewing Company",
                    RestaurantAddress = "1291 University Ave, Morgantown, WV 26505",
                    PriceRangeID = 3,
                    RestaurantOwner = null,
                    FoodTypeID = 9,
                    AreaID = 1,
                    DeliveryServiceID = 2
                    

                };
                database.Restaurants.Add(Rest);
                Rest = new Restaurant
                {
                    RestaurantName = "Keglers",
                    RestaurantAddress = "735 Chestnut Ridge Rd A, Morgantown, WV 26505",
                    PriceRangeID = 3,
                    RestaurantOwner = null,
                    FoodTypeID = 9,
                    AreaID = 2,
                    DeliveryServiceID = 1

                }; 
                database.Restaurants.Add(Rest);
                Rest = new Restaurant
                {
                    RestaurantName = "Black Bear Burritos",
                    RestaurantAddress = "3119 University Ave, Morgantown, WV 26505",
                    PriceRangeID = 3,
                    RestaurantOwner = null,
                    FoodTypeID = 1,
                    AreaID = 1,
                    DeliveryServiceID = 2

                };
                database.Restaurants.Add(Rest);
                Rest = new Restaurant
                {
                    RestaurantName = "IHOP",
                    RestaurantAddress = "475 Oakland St, Morgantown, WV 26505",
                    PriceRangeID = 2,
                    RestaurantOwner = null,
                    FoodTypeID = 11,
                    AreaID = 2,
                    DeliveryServiceID = 5
                    

                };
                database.Restaurants.Add(Rest);
                Rest = new Restaurant
                {
                    RestaurantName = "Buffalo Wild Wings",
                    RestaurantAddress = "1099 Suncrest Towne Centre Drive, Morgantown, WV 26505",
                    PriceRangeID = 3,
                    RestaurantOwner = null,
                    FoodTypeID = 9,
                    AreaID = 2,
                    DeliveryServiceID = 5


                };
                database.Restaurants.Add(Rest);
                database.SaveChanges();



            }
            if(!database.Dishes.Any())
            {
                Dish D = new Dish
                {
                    DishName ="Burrito",
                    DishDescription ="Flour tortilla wrapped in a choice of barbacoa, carnitas, chicken, sofritas, steak, or veggie.  Comes with rice, your choice of beans, sour cream, and fresh veggies.  Guac is extra.",
                    
                    
                    

                };
                database.Dishes.Add(D);
                D = new Dish
                {
                    DishName = "Burrito Bowl",
                    DishDescription = "A bowl full of a choice of barbacoa, carnitas, chicken, sofritas, steak, or veggie.  Comes with rice, your choice of beans, sour cream, and fresh veggies.  Guac is extra."
                    

                };
                database.Dishes.Add(D);
                D = new Dish
                {
                    DishName = "Large Cheese Pizza",
                    DishDescription = "A bowl full of a choice of barbacoa, carnitas, chicken, sofritas, steak, or veggie.  Comes with rice, your choice of beans, sour cream, and fresh veggies.  Guac is extra."
                    
                                      
                };
                database.Dishes.Add(D);

                database.SaveChanges();

            }
            if(!database.restaurant_Dishes.Any())
            {
                Restaurant_Dish RD = new Restaurant_Dish
                {
                    RestaurantID = 1,
                    DishID = 1
                };
                database.restaurant_Dishes.Add(RD);
                RD = new Restaurant_Dish
                {
                    RestaurantID = 1,
                    DishID = 2
                };
                database.restaurant_Dishes.Add(RD);
                RD = new Restaurant_Dish
                {
                    RestaurantID = 2,
                    DishID = 3
                };
                database.restaurant_Dishes.Add(RD);
                RD = new Restaurant_Dish
                {
                    RestaurantID = 3,
                    DishID = 3
                };
                database.restaurant_Dishes.Add(RD);


                database.SaveChanges();
            }

        }


    }
}
