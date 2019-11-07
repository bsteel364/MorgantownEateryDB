using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MorgantownRestaurantsV2.Data.Migrations
{
    public partial class AddedDeliveryService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeliveryServiceID",
                table: "Restaurants",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DeliveryServices",
                columns: table => new
                {
                    DeliveryServiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DeliveryServiceName = table.Column<string>(nullable: true),
                    DeliveryServiceType = table.Column<string>(nullable: true),
                    DeliveryFee = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryServices", x => x.DeliveryServiceID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_DeliveryServiceID",
                table: "Restaurants",
                column: "DeliveryServiceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_DeliveryServices_DeliveryServiceID",
                table: "Restaurants",
                column: "DeliveryServiceID",
                principalTable: "DeliveryServices",
                principalColumn: "DeliveryServiceID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_DeliveryServices_DeliveryServiceID",
                table: "Restaurants");

            migrationBuilder.DropTable(
                name: "DeliveryServices");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_DeliveryServiceID",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "DeliveryServiceID",
                table: "Restaurants");
        }
    }
}
