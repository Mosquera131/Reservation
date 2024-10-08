﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Reserva.Data;

#nullable disable

namespace Reserva.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241007140446_SeederCreations")]
    partial class SeederCreations
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Reserva.Models.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Employee_id")
                        .HasColumnType("int");

                    b.Property<int>("Employeed_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("End_date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("End Date");

                    b.Property<int>("Guest_id")
                        .HasColumnType("int");

                    b.Property<int>("Room_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("Start_date")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("Start Date");

                    b.Property<double>("Total_cost")
                        .HasColumnType("double")
                        .HasColumnName("Total Cost");

                    b.HasKey("Id");

                    b.HasIndex("Employeed_id");

                    b.HasIndex("Guest_id");

                    b.HasIndex("Room_id");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Reserva.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Email");

                    b.Property<string>("Firt_name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Firt Name");

                    b.Property<string>("Identification_number")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Identification Number");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Last Name");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Password");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Reserva.Models.Guest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Birthdate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("Birthdate");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Email");

                    b.Property<string>("Firts_name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("First Name");

                    b.Property<string>("Identification_number")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Identification Number");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Last Name");

                    b.Property<string>("Phone_number")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Phone Number");

                    b.HasKey("Id");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("Reserva.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Availability")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("Availability");

                    b.Property<byte>("Max_ocuppancy_persons")
                        .HasColumnType("tinyint unsigned")
                        .HasColumnName("Max Ocupancy");

                    b.Property<double>("Price_per_night")
                        .HasColumnType("double")
                        .HasColumnName("Price Per Night");

                    b.Property<int>("Room_number")
                        .HasColumnType("int")
                        .HasColumnName("Room Number");

                    b.Property<int>("Room_type_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Room_type_id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("Reserva.Models.Room_type", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("longtext")
                        .HasColumnName("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.ToTable("Room Types");
                });

            modelBuilder.Entity("Reserva.Models.Booking", b =>
                {
                    b.HasOne("Reserva.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("Employeed_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reserva.Models.Guest", "Guest")
                        .WithMany()
                        .HasForeignKey("Guest_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Reserva.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("Room_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Guest");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Reserva.Models.Room", b =>
                {
                    b.HasOne("Reserva.Models.Room_type", "Room_Type")
                        .WithMany()
                        .HasForeignKey("Room_type_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room_Type");
                });
#pragma warning restore 612, 618
        }
    }
}
