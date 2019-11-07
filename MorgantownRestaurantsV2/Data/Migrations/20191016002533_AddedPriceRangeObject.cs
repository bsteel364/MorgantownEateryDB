using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MorgantownRestaurantsV2.Data.Migrations
{
    public partial class AddedPriceRangeObject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RestaurantPriceRange",
                table: "Restaurants");

            migrationBuilder.AddColumn<int>(
                name: "PriceRangeID",
                table: "Restaurants",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PriceRanges",
                columns: table => new
                {
                    PriceRangeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PriceRangeRating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceRanges", x => x.PriceRangeID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_PriceRangeID",
                table: "Restaurants",
                column: "PriceRangeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_PriceRanges_PriceRangeID",
                table: "Restaurants",
                column: "PriceRangeID",
                principalTable: "PriceRanges",
                principalColumn: "PriceRangeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_PriceRanges_PriceRangeID",
                table: "Restaurants");

            migrationBuilder.DropTable(
                name: "PriceRanges");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_PriceRangeID",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "PriceRangeID",
                table: "Restaurants");

            migrationBuilder.AddColumn<string>(
                name: "RestaurantPriceRange",
                table: "Restaurants",
                nullable: true);
        }
    }
}
