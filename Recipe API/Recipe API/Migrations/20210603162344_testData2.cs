using Microsoft.EntityFrameworkCore.Migrations;

namespace Recipe_API.Migrations
{
    public partial class testData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name", "Quantity", "RecipeId", "Unit" },
                values: new object[,]
                {
                    { 1, "Scampi's", 500.0, 1, "gram" },
                    { 2, "Tomaten", 4.0, 1, null },
                    { 3, "Look", 1.0, 1, "teen" },
                    { 4, "Room", 1.0, 1, "liter" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
