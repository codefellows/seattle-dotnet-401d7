using Microsoft.EntityFrameworkCore.Migrations;

namespace Class13IntroToEFCore.Migrations
{
    public partial class seededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "ID", "Name", "Price", "Tech" },
                values: new object[,]
                {
                    { 1, "Underwater Basket Weaving", 10.00m, 0 },
                    { 2, "Intro To Azure", 50.00m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "Age", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 50, "Big Bird", "Yellow" },
                    { 2, 44, "Miss Piggy", "Muppet" },
                    { 3, 65, "Kermit", "The Frog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
