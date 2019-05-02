using Microsoft.EntityFrameworkCore.Migrations;

namespace CMSBlogPost.Migrations.BlogDb
{
    public partial class newSeededData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "They are the best!", "Tacos are Delicious" },
                    { 2, "Josie is the queen of the household", "Josie Cat" },
                    { 3, "Belle loves to lay around the house and meow", "Belle Kitty" },
                    { 4, ".NET is the bestest of the best!! We all love to code in C#!!!!!", ".NET ROCKS" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
