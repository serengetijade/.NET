﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project_SWAPI.Models;

#nullable disable

namespace Project_SWAPI.Migrations
{
    [DbContext(typeof(SWAPIContext))]
    partial class SWAPIContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Project_SWAPI.Models.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("characters")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("director")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("episode_id")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("opening_crawl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("planets")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("producer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("release_date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("species")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("starships")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vehicles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Films");
                });

            modelBuilder.Entity("Project_SWAPI.Models.People", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("birth_year")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("edited")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eye_color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("films")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hair_color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("height")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("homeworld")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("skin_color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("species")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("starships")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vehicles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("People");
                });

            modelBuilder.Entity("Project_SWAPI.Models.Planet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("climate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("diameter")
                        .HasColumnType("int");

                    b.Property<string>("edited")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("films")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gravity")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("orbital_period")
                        .HasColumnType("int");

                    b.Property<int>("population")
                        .HasColumnType("int");

                    b.Property<string>("residents")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rotation_period")
                        .HasColumnType("int");

                    b.Property<int>("surface_water")
                        .HasColumnType("int");

                    b.Property<string>("terrain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Planets");
                });

            modelBuilder.Entity("Project_SWAPI.Models.Species", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("average_height")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("average_lifespan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("classification")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("designation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("edited")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("eye_colors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("films")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hair_colors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("homeworld")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("language")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("people")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("skin_colors")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Species");
                });

            modelBuilder.Entity("Project_SWAPI.Models.Starship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("MGLT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cargo_capacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("consumables")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cost_in_credits")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("crew")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("edited")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("films")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hyperdrive_rating")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("length")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("max_atmosphering_speed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passengers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pilots")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("starship_class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Starships");
                });

            modelBuilder.Entity("Project_SWAPI.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("cargo_capacity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("consumables")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("cost_in_credits")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("created")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("crew")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("edited")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("films")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("length")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("max_atmosphering_speed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passengers")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pilots")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vehicle_class")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
