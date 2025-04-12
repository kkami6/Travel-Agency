using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Hotels_CityId",
                table: "Hotels",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Excursions_CityId",
                table: "Excursions",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Excursions_HotelId",
                table: "Excursions",
                column: "HotelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Excursions_Cities_CityId",
                table: "Excursions",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Excursions_Hotels_HotelId",
                table: "Excursions",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "HotelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Cities_CityId",
                table: "Hotels",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Excursions_Cities_CityId",
                table: "Excursions");

            migrationBuilder.DropForeignKey(
                name: "FK_Excursions_Hotels_HotelId",
                table: "Excursions");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Cities_CityId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_CityId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Excursions_CityId",
                table: "Excursions");

            migrationBuilder.DropIndex(
                name: "IX_Excursions_HotelId",
                table: "Excursions");
        }
    }
}
