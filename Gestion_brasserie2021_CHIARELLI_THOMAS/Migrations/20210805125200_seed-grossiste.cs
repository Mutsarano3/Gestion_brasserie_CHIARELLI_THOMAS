using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.Migrations
{
    public partial class seedgrossiste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Wholesalers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Wholesalers",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "TestGrossiste" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Wholesalers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Wholesalers");
        }
    }
}
