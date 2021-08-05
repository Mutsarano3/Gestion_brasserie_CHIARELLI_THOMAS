using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.Migrations
{
    public partial class changenavigationbeerwholesaler : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BeerWholesalers_Breweries_IdBeer",
                table: "BeerWholesalers");

            migrationBuilder.AddForeignKey(
                name: "FK_BeerWholesalers_Beers_IdBeer",
                table: "BeerWholesalers",
                column: "IdBeer",
                principalTable: "Beers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BeerWholesalers_Beers_IdBeer",
                table: "BeerWholesalers");

            migrationBuilder.AddForeignKey(
                name: "FK_BeerWholesalers_Breweries_IdBeer",
                table: "BeerWholesalers",
                column: "IdBeer",
                principalTable: "Breweries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
