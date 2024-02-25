using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GBC_Travel_Group23.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_CarRental_ServiceId",
                table: "Bookings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarRental",
                table: "CarRental");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "ArrivalAirportCode",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "ArrivalCity",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "ArrivalCountry",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "DepartureAirportCode",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "DepartureCity",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "DepartureCountry",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "CarBrand",
                table: "CarRental");

            migrationBuilder.DropColumn(
                name: "CarModel",
                table: "CarRental");

            migrationBuilder.RenameTable(
                name: "CarRental",
                newName: "CarRentals");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Hotels",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "CarRentals",
                newName: "Model");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "CarRentals",
                newName: "Make");

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArrivalLocationId",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DepartureLocationId",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LocationId",
                table: "CarRentals",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarRentals",
                table: "CarRentals",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AirportCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_LocationId",
                table: "Hotels",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_ArrivalLocationId",
                table: "Flights",
                column: "ArrivalLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_DepartureLocationId",
                table: "Flights",
                column: "DepartureLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_CarRentals_LocationId",
                table: "CarRentals",
                column: "LocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_CarRentals_ServiceId",
                table: "Bookings",
                column: "ServiceId",
                principalTable: "CarRentals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CarRentals_Locations_LocationId",
                table: "CarRentals",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Locations_ArrivalLocationId",
                table: "Flights",
                column: "ArrivalLocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Locations_DepartureLocationId",
                table: "Flights",
                column: "DepartureLocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hotels_Locations_LocationId",
                table: "Hotels",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_CarRentals_ServiceId",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_CarRentals_Locations_LocationId",
                table: "CarRentals");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Locations_ArrivalLocationId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Locations_DepartureLocationId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Hotels_Locations_LocationId",
                table: "Hotels");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Hotels_LocationId",
                table: "Hotels");

            migrationBuilder.DropIndex(
                name: "IX_Flights_ArrivalLocationId",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_DepartureLocationId",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarRentals",
                table: "CarRentals");

            migrationBuilder.DropIndex(
                name: "IX_CarRentals_LocationId",
                table: "CarRentals");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "ArrivalLocationId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "DepartureLocationId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "CarRentals");

            migrationBuilder.RenameTable(
                name: "CarRentals",
                newName: "CarRental");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Hotels",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "Model",
                table: "CarRental",
                newName: "Country");

            migrationBuilder.RenameColumn(
                name: "Make",
                table: "CarRental",
                newName: "City");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArrivalAirportCode",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArrivalCity",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ArrivalCountry",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DepartureAirportCode",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DepartureCity",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DepartureCountry",
                table: "Flights",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarBrand",
                table: "CarRental",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CarModel",
                table: "CarRental",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarRental",
                table: "CarRental",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_CarRental_ServiceId",
                table: "Bookings",
                column: "ServiceId",
                principalTable: "CarRental",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
