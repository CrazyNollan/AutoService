﻿// <auto-generated />
using AutoService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AutoService.Data.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20180422171045_DefaultDataLoadInAddresses")]
    partial class DefaultDataLoadInAddresses
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoService.Data.Entities.AddressEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnName("City");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnName("Country");

                    b.Property<int>("House")
                        .HasColumnName("House");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnName("Street");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("AutoService.Data.Entities.ClientEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<int>("AddressId")
                        .HasColumnName("AddressId");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name");

                    b.Property<string>("Patronymic")
                        .IsRequired()
                        .HasColumnName("Patronymic");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnName("Surname");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("AutoService.Data.Entities.DriverLicenseEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<int>("ClientId")
                        .HasColumnName("ClientId");

                    b.Property<int>("Day")
                        .HasColumnName("Day");

                    b.Property<int>("Month")
                        .HasColumnName("Month");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnName("Number");

                    b.Property<int>("TransportCategoryId")
                        .HasColumnName("TransportCategoryId");

                    b.Property<int>("Year")
                        .HasColumnName("Year");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("Number")
                        .IsUnique();

                    b.HasIndex("TransportCategoryId");

                    b.ToTable("DriverLicenses");
                });

            modelBuilder.Entity("AutoService.Data.Entities.FuelEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Fuel");
                });

            modelBuilder.Entity("AutoService.Data.Entities.InspectionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<int>("ExpireYear")
                        .HasColumnName("ExpireYear");

                    b.Property<bool>("IsPassed")
                        .HasColumnName("IsPassed");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnName("Number");

                    b.Property<int>("StartYear")
                        .HasColumnName("StartYear");

                    b.Property<int>("TransportId")
                        .HasColumnName("TransportId");

                    b.HasKey("Id");

                    b.HasIndex("Number")
                        .IsUnique();

                    b.HasIndex("TransportId");

                    b.ToTable("Inspections");
                });

            modelBuilder.Entity("AutoService.Data.Entities.TransportCategoryEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("TransportCategories");
                });

            modelBuilder.Entity("AutoService.Data.Entities.TransportEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<int>("ClientId")
                        .HasColumnName("ClientId");

                    b.Property<int>("FuelId")
                        .HasColumnName("FuelId");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnName("Number");

                    b.Property<int>("TransportCategoryId")
                        .HasColumnName("TransportCategoryId");

                    b.Property<int>("TransportMakeId")
                        .HasColumnName("TransportMakeId");

                    b.Property<int>("TransportModelId")
                        .HasColumnName("TransportModelId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("FuelId");

                    b.HasIndex("Number")
                        .IsUnique();

                    b.HasIndex("TransportCategoryId");

                    b.HasIndex("TransportMakeId");

                    b.HasIndex("TransportModelId");

                    b.ToTable("Transport");
                });

            modelBuilder.Entity("AutoService.Data.Entities.TransportMakeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("TransportMakes");
                });

            modelBuilder.Entity("AutoService.Data.Entities.TransportModelEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("TransportModels");
                });

            modelBuilder.Entity("AutoService.Data.Entities.ClientEntity", b =>
                {
                    b.HasOne("AutoService.Data.Entities.AddressEntity", "Address")
                        .WithMany("Clients")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutoService.Data.Entities.DriverLicenseEntity", b =>
                {
                    b.HasOne("AutoService.Data.Entities.ClientEntity", "Client")
                        .WithMany("DriverLicenses")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoService.Data.Entities.TransportCategoryEntity", "TransportCategory")
                        .WithMany("DriverLicenses")
                        .HasForeignKey("TransportCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutoService.Data.Entities.InspectionEntity", b =>
                {
                    b.HasOne("AutoService.Data.Entities.TransportEntity", "Transport")
                        .WithMany("Inspections")
                        .HasForeignKey("TransportId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AutoService.Data.Entities.TransportEntity", b =>
                {
                    b.HasOne("AutoService.Data.Entities.ClientEntity", "Client")
                        .WithMany("Transport")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoService.Data.Entities.FuelEntity", "Fuel")
                        .WithMany("Transport")
                        .HasForeignKey("FuelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoService.Data.Entities.TransportCategoryEntity", "Category")
                        .WithMany("Transport")
                        .HasForeignKey("TransportCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoService.Data.Entities.TransportMakeEntity", "Make")
                        .WithMany("Transport")
                        .HasForeignKey("TransportMakeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AutoService.Data.Entities.TransportModelEntity", "Model")
                        .WithMany("Transport")
                        .HasForeignKey("TransportModelId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
