using Microsoft.EntityFrameworkCore.Migrations;

namespace MorgantownRestaurantsV2.Data.Migrations
{
    public partial class deletedIsVegan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isVegan",
                table: "Restaurants");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "isVegan",
                table: "Restaurants",
                nullable: true);
        }
    }
}
