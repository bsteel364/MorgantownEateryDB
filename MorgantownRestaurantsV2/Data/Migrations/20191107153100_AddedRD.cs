using Microsoft.EntityFrameworkCore.Migrations;

namespace MorgantownRestaurantsV2.Data.Migrations
{
    public partial class AddedRD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_restaurant_Dishes_DishID",
                table: "restaurant_Dishes",
                column: "DishID");

            migrationBuilder.CreateIndex(
                name: "IX_restaurant_Dishes_RestaurantID",
                table: "restaurant_Dishes",
                column: "RestaurantID");

            migrationBuilder.AddForeignKey(
                name: "FK_restaurant_Dishes_Dishes_DishID",
                table: "restaurant_Dishes",
                column: "DishID",
                principalTable: "Dishes",
                principalColumn: "DishID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_restaurant_Dishes_Restaurants_RestaurantID",
                table: "restaurant_Dishes",
                column: "RestaurantID",
                principalTable: "Restaurants",
                principalColumn: "RestaurantID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_restaurant_Dishes_Dishes_DishID",
                table: "restaurant_Dishes");

            migrationBuilder.DropForeignKey(
                name: "FK_restaurant_Dishes_Restaurants_RestaurantID",
                table: "restaurant_Dishes");

            migrationBuilder.DropIndex(
                name: "IX_restaurant_Dishes_DishID",
                table: "restaurant_Dishes");

            migrationBuilder.DropIndex(
                name: "IX_restaurant_Dishes_RestaurantID",
                table: "restaurant_Dishes");
        }
    }
}
