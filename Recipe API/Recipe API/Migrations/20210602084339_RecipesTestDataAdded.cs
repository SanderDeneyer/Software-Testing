using Microsoft.EntityFrameworkCore.Migrations;

namespace Recipe_API.Migrations
{
    public partial class RecipesTestDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Dificulty", "Time", "Title" },
                values: new object[] { 2, 2, 60, "Pasta Test" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "Dificulty", "Time", "Title" },
                values: new object[,]
                {
                    { 4, 2, 2, 60, "Pasta Test2" },
                    { 5, 2, 2, 60, "Pasta Test3" },
                    { 6, 3, 1, 15, "Framboze ijsje" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Dificulty", "Time", "Title" },
                values: new object[] { 3, 1, 15, "Framboze ijsje" });
        }
    }
}
