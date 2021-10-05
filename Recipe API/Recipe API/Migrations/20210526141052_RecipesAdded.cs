using Microsoft.EntityFrameworkCore.Migrations;

namespace Recipe_API.Migrations
{
    public partial class RecipesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "Dificulty", "Time", "Title" },
                values: new object[] { 1, 1, 0, 45, "Scampi soupje" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "Dificulty", "Time", "Title" },
                values: new object[] { 2, 2, 2, 60, "Pasta Diablo" });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "Dificulty", "Time", "Title" },
                values: new object[] { 3, 3, 1, 15, "Framboze ijsje" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
