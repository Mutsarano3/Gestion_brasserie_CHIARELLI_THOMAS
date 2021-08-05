using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.Migrations
{
    public partial class entitybeerbrewer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Breweries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Alchool",
                table: "Beers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "IdBrewer",
                table: "Beers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Beers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Beers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateIndex(
                name: "IX_Beers_IdBrewer",
                table: "Beers",
                column: "IdBrewer");

            migrationBuilder.AddForeignKey(
                name: "FK_Beers_Breweries_IdBrewer",
                table: "Beers",
                column: "IdBrewer",
                principalTable: "Breweries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beers_Breweries_IdBrewer",
                table: "Beers");

            migrationBuilder.DropIndex(
                name: "IX_Beers_IdBrewer",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Breweries");

            migrationBuilder.DropColumn(
                name: "Alchool",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "IdBrewer",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Beers");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Beers");
        }
    }
}
