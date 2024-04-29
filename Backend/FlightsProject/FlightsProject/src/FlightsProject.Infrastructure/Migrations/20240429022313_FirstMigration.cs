using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightsProject.Infrastructure.Migrations;

  /// <inheritdoc />
  public partial class FirstMigration : Migration
  {
      /// <inheritdoc />
      protected override void Up(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.CreateTable(
              name: "Journeys",
              columns: table => new
              {
                  Id = table.Column<Guid>(type: "TEXT", nullable: false),
                  Origin = table.Column<string>(type: "TEXT", nullable: false),
                  Destination = table.Column<string>(type: "TEXT", nullable: false),
                  Price = table.Column<double>(type: "REAL", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Journeys", x => x.Id);
              });

          migrationBuilder.CreateTable(
              name: "Transport",
              columns: table => new
              {
                  Id = table.Column<Guid>(type: "TEXT", nullable: false),
                  FlightCarrier = table.Column<string>(type: "TEXT", nullable: false),
                  FlightNumber = table.Column<string>(type: "TEXT", nullable: false)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Transport", x => x.Id);
              });

          migrationBuilder.CreateTable(
              name: "Flight",
              columns: table => new
              {
                  Id = table.Column<Guid>(type: "TEXT", nullable: false),
                  Origin = table.Column<string>(type: "TEXT", nullable: true),
                  Destination = table.Column<string>(type: "TEXT", nullable: true),
                  Price = table.Column<double>(type: "REAL", nullable: true),
                  TransportId = table.Column<Guid>(type: "TEXT", nullable: true),
                  JourneyId = table.Column<Guid>(type: "TEXT", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Flight", x => x.Id);
                  table.ForeignKey(
                      name: "FK_Flight_Journeys_JourneyId",
                      column: x => x.JourneyId,
                      principalTable: "Journeys",
                      principalColumn: "Id");
                  table.ForeignKey(
                      name: "FK_Flight_Transport_TransportId",
                      column: x => x.TransportId,
                      principalTable: "Transport",
                      principalColumn: "Id");
              });

          migrationBuilder.CreateIndex(
              name: "IX_Flight_JourneyId",
              table: "Flight",
              column: "JourneyId");

          migrationBuilder.CreateIndex(
              name: "IX_Flight_TransportId",
              table: "Flight",
              column: "TransportId");
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropTable(
              name: "Flight");

          migrationBuilder.DropTable(
              name: "Journeys");

          migrationBuilder.DropTable(
              name: "Transport");
      }
  }
