using Microsoft.EntityFrameworkCore.Migrations;

namespace Gestion_brasserie2021_CHIARELLI_THOMAS.Migrations
{
    public partial class Beerwholesaler_entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeerWholesalers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdBeer = table.Column<int>(type: "int", nullable: false),
                    IdWholesaler = table.Column<int>(type: "int", nullable: false),
                    BeerQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeerWholesalers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BeerWholesalers_Breweries_IdBeer",
                        column: x => x.IdBeer,
                        principalTable: "Breweries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BeerWholesalers_Wholesalers_IdWholesaler",
                        column: x => x.IdWholesaler,
                        principalTable: "Wholesalers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BeerWholesalers_IdBeer",
                table: "BeerWholesalers",
                column: "IdBeer");

            migrationBuilder.CreateIndex(
                name: "IX_BeerWholesalers_IdWholesaler",
                table: "BeerWholesalers",
                column: "IdWholesaler");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BeerWholesalers");
        }
    }
}
