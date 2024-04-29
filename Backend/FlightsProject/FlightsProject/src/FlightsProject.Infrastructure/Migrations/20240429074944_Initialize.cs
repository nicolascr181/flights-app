using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightsProject.Infrastructure.Migrations;

  /// <inheritdoc />
  public partial class Initialize : Migration
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
              name: "Flights",
              columns: table => new
              {
                  Id = table.Column<Guid>(type: "TEXT", nullable: false),
                  Origin = table.Column<string>(type: "TEXT", nullable: false),
                  Destination = table.Column<string>(type: "TEXT", nullable: false),
                  Price = table.Column<double>(type: "REAL", nullable: true),
                  JourneyId = table.Column<Guid>(type: "TEXT", nullable: true),
                  TRANSPORT = table.Column<string>(type: "TEXT", nullable: true)
              },
              constraints: table =>
              {
                  table.PrimaryKey("PK_Flights", x => x.Id);
                  table.ForeignKey(
                      name: "FK_Flights_Journeys_JourneyId",
                      column: x => x.JourneyId,
                      principalTable: "Journeys",
                      principalColumn: "Id");
              });

          migrationBuilder.CreateIndex(
              name: "IX_Flights_JourneyId",
              table: "Flights",
              column: "JourneyId");
      }

      /// <inheritdoc />
      protected override void Down(MigrationBuilder migrationBuilder)
      {
          migrationBuilder.DropTable(
              name: "Flights");

          migrationBuilder.DropTable(
              name: "Journeys");
      }
  }
