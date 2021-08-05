using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.Migrations
{
    public partial class seedBrewer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Breweries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Test" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Breweries",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
