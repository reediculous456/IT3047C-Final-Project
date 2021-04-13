﻿// <auto-generated />
using HikingTrails.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HikingTrails.Migrations
{
    [DbContext(typeof(HikingTrailsContext))]
    [Migration("20210413013100_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HikingTrails.Models.Trail", b =>
                {
                    b.Property<int>("TrailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrailName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrailId");

                    b.ToTable("Trail");

                    b.HasData(
                        new
                        {
                            TrailId = 1,
                            Location = "Milford, OH",
                            TrailName = "Rowe Woods"
                        },
                        new
                        {
                            TrailId = 2,
                            Location = "Goshen, OH",
                            TrailName = "Long Branch Farm"
                        });
                });

            modelBuilder.Entity("HikingTrails.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Age = 0,
                            FirstName = "Anthony",
                            LastName = "Morgan"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}