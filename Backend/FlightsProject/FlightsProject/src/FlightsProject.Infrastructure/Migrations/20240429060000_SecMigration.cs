using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightsProject.Infrastructure.Migrations;

  /// <inheritdoc />
  public partial class SecMigration : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropForeignKey(
              name: "FK_Flight_Journeys_JourneyId",
              table: "Flight");

          migrationBuilder.DropForeignKey(
              name: "FK_Flight_Transport_TransportId",
              table: "Flight");

          migrationBuilder.DropPrimaryKey(
              name: "PK_Flight",
              table: "Flight");

          migrationBuilder.RenameTable(
              name: "Flight",
              newName: "Flights");

          migrationBuilder.RenameIndex(
              name: "IX_Flight_TransportId",
              table: "Flights",
              newName: "IX_Flights_TransportId");

          migrationBuilder.RenameIndex(
              name: "IX_Flight_JourneyId",
              table: "Flights",
              newName: "IX_Flights_JourneyId");

          migrationBuilder.AddPrimaryKey(
              name: "PK_Flights",
              table: "Flights",
              column: "Id");

          migrationBuilder.AddForeignKey(
              name: "FK_Flights_Journeys_JourneyId",
              table: "Flights",
              column: "JourneyId",
              principalTable: "Journeys",
              principalColumn: "Id");

          migrationBuilder.AddForeignKey(
              name: "FK_Flights_Transport_TransportId",
              table: "Flights",
              column: "TransportId",
              principalTable: "Transport",
              principalColumn: "Id");
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropForeignKey(
              name: "FK_Flights_Journeys_JourneyId",
              table: "Flights");

          migrationBuilder.DropForeignKey(
              name: "FK_Flights_Transport_TransportId",
              table: "Flights");

          migrationBuilder.DropPrimaryKey(
              name: "PK_Flights",
              table: "Flights");

          migrationBuilder.RenameTable(
              name: "Flights",
              newName: "Flight");

          migrationBuilder.RenameIndex(
              name: "IX_Flights_TransportId",
              table: "Flight",
              newName: "IX_Flight_TransportId");

          migrationBuilder.RenameIndex(
              name: "IX_Flights_JourneyId",
              table: "Flight",
              newName: "IX_Flight_JourneyId");

          migrationBuilder.AddPrimaryKey(
              name: "PK_Flight",
              table: "Flight",
              column: "Id");

          migrationBuilder.AddForeignKey(
              name: "FK_Flight_Journeys_JourneyId",
              table: "Flight",
              column: "JourneyId",
              principalTable: "Journeys",
              principalColumn: "Id");

          migrationBuilder.AddForeignKey(
              name: "FK_Flight_Transport_TransportId",
              table: "Flight",
              column: "TransportId",
              principalTable: "Transport",
              principalColumn: "Id");
      }
  }
