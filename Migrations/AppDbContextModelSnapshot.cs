﻿// <auto-generated />
using System;
using GBC_Travel_Group23.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GBC_Travel_Group23.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GBC_Travel_Group23.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("GuestCount")
                        .HasColumnType("int");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("GBC_Travel_Group23.Models.CarRental", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("CarBrand")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CarModel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarYear")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("CarRental");
                });

            modelBuilder.Entity("GBC_Travel_Group23.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("GBC_Travel_Group23.Models.Flight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Airline")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrivalAirportCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrivalCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArrivalCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ArrivalDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DepartureAirportCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DepartureCountry")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DepartureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FlightCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plane")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("TotalSeats")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Flights");
                });

            modelBuilder.Entity("GBC_Travel_Group23.Models.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Amenities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("GBC_Travel_Group23.Models.HotelRoom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Amenities")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<int>("MaxOccupants")
                        .HasColumnType("int");

                    b.Property<double>("Rate")
                        .HasColumnType("float");

                    b.Property<int>("RoomCount")
                        .HasColumnType("int");

                    b.Property<string>("RoomName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HotelId");

                    b.ToTable("HotelRooms");
                });

            modelBuilder.Entity("GBC_Travel_Group23.Models.Booking", b =>
                {
                    b.HasOne("GBC_Travel_Group23.Models.Client", "Client")
                        .WithMany("Bookings")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GBC_Travel_Group23.Models.CarRental", "CarRental")
                        .WithMany("Bookings")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GBC_Travel_Group23.Models.Flight", "Flight")
                        .WithMany("Bookings")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("GBC_Travel_Group23.Models.HotelRoom", "HotelRoom")
                        .WithMany("Bookings")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("CarRental");

                    b.Navigation("Client");

                    b.Navigation("Flight");

                    b.Navigation("HotelRoom");
                });

            modelBuilder.Entity("GBC_Travel_Group23.Models.HotelRoom", b =>
                {
                    b.HasOne("GBC_Travel_Group23.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Hotel");
                });

            modelBuilder.Entity("GBC_Travel_Group23.Models.CarRental", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("GBC_Travel_Group23.Models.Client", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("GBC_Travel_Group23.Models.Flight", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("GBC_Travel_Group23.Models.Hotel", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("GBC_Travel_Group23.Models.HotelRoom", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
