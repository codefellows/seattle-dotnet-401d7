using Microsoft.EntityFrameworkCore.Migrations;

namespace Week6RestaurantFinder.Migrations
{
    public partial class newSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "ID", "Description", "Name", "StarRating", "URL" },
                values: new object[] { 1, null, "Chace's Pancake Coral", 4, "chace.jpg" });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "ID", "Description", "Name", "StarRating", "URL" },
                values: new object[] { 2, null, "SmallCakes", 5, "cupcake.png" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
