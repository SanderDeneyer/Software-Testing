using Microsoft.EntityFrameworkCore.Migrations;

namespace Recipe_API.Migrations
{
    public partial class testData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CategoryId", "Dificulty", "Time", "Title" },
                values: new object[] { 7, 1, 1, 35, "Pasta 1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
