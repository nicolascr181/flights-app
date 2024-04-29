﻿// <auto-generated />
using System;
using FlightsProject.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlightsProject.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240429022313_FirstMigration")]
    partial class FirstMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("FlightsProject.Core.Entities.Flight", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Destination")
                        .HasColumnType("TEXT");

                    b.Property<Guid?>("JourneyId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Origin")
                        .HasColumnType("TEXT");

                    b.Property<double?>("Price")
                        .HasColumnType("REAL");

                    b.Property<Guid?>("TransportId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("JourneyId");

                    b.HasIndex("TransportId");

                    b.ToTable("Flight");
                });

            modelBuilder.Entity("FlightsProject.Core.Entities.Journey", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double?>("Price")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Journeys");
                });

            modelBuilder.Entity("FlightsProject.Core.Entities.Transport", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("FlightCarrier")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FlightNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Transport");
                });

            modelBuilder.Entity("FlightsProject.Core.Entities.Flight", b =>
                {
                    b.HasOne("FlightsProject.Core.Entities.Journey", null)
                        .WithMany("Flights")
                        .HasForeignKey("JourneyId");

                    b.HasOne("FlightsProject.Core.Entities.Transport", "Transport")
                        .WithMany()
                        .HasForeignKey("TransportId");

                    b.Navigation("Transport");
                });

            modelBuilder.Entity("FlightsProject.Core.Entities.Journey", b =>
                {
                    b.Navigation("Flights");
                });
#pragma warning restore 612, 618
        }
    }
}
