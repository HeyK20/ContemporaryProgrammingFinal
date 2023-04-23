﻿// <auto-generated />
using System;
using ContemporaryProgrammingFinal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContemporaryProgrammingFinal.Migrations
{
    [DbContext(typeof(TeamInfoContext))]
    [Migration("20230422025207_nine")]
    partial class nine
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ContemporaryProgrammingFinal.Models.Breakfast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<string>("Cold")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FatContent")
                        .HasColumnType("int");

                    b.Property<string>("Hot")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Refridgerated")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Calories = 60,
                            Cold = "n",
                            FatContent = 5,
                            Hot = "y",
                            Name = "Eggs",
                            Refridgerated = "n"
                        },
                        new
                        {
                            Id = 2,
                            Calories = 100,
                            Cold = "n",
                            FatContent = 4,
                            Hot = "y",
                            Name = "Pancakes",
                            Refridgerated = "n"
                        },
                        new
                        {
                            Id = 3,
                            Calories = 70,
                            Cold = "n",
                            FatContent = 7,
                            Hot = "y",
                            Name = "Bacon",
                            Refridgerated = "n"
                        },
                        new
                        {
                            Id = 4,
                            Calories = 150,
                            Cold = "y",
                            FatContent = 3,
                            Hot = "n",
                            Name = "Cereal",
                            Refridgerated = "n"
                        },
                        new
                        {
                            Id = 5,
                            Calories = 85,
                            Cold = "n",
                            FatContent = 4,
                            Hot = "y",
                            Name = "Sausage",
                            Refridgerated = "n"
                        });
                });

            modelBuilder.Entity("ContemporaryProgrammingFinal.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MakeModel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ManufacturerYear")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrimLevel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Black",
                            MakeModel = "Honda Civic",
                            ManufacturerYear = "2017",
                            TrimLevel = "Sport",
                            Type = "Hatchback"
                        },
                        new
                        {
                            Id = 2,
                            Color = "White",
                            MakeModel = "Toyota Corola",
                            ManufacturerYear = "2022",
                            TrimLevel = "SE",
                            Type = "Sedan"
                        },
                        new
                        {
                            Id = 3,
                            Color = "Blue",
                            MakeModel = "Ford Fusion",
                            ManufacturerYear = "2020",
                            TrimLevel = "SEL",
                            Type = "Sedan"
                        },
                        new
                        {
                            Id = 4,
                            Color = "Red",
                            MakeModel = "Chevy Cruze",
                            ManufacturerYear = "2019",
                            TrimLevel = "LT",
                            Type = "Sedan"
                        },
                        new
                        {
                            Id = 5,
                            Color = "Gray",
                            MakeModel = "Tesla Model Y",
                            ManufacturerYear = "2023",
                            TrimLevel = "Fully Autonomous",
                            Type = "SUV"
                        });
                });

            modelBuilder.Entity("ContemporaryProgrammingFinal.Models.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GameCategory")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayTime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlayerAges")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerMaximum")
                        .HasColumnType("int");

                    b.Property<int>("PlayerMinimum")
                        .HasColumnType("int");

                    b.Property<int>("ReleaseYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Games");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GameCategory = "Party",
                            Name = "Monikers",
                            PlayTime = "30-60 Minutes",
                            PlayerAges = "17+",
                            PlayerMaximum = 16,
                            PlayerMinimum = 4,
                            ReleaseYear = 2015
                        },
                        new
                        {
                            Id = 2,
                            GameCategory = "Card",
                            Name = "Cat in the Box",
                            PlayTime = "30-45 Minutes",
                            PlayerAges = "10+",
                            PlayerMaximum = 4,
                            PlayerMinimum = 3,
                            ReleaseYear = 2020
                        },
                        new
                        {
                            Id = 3,
                            GameCategory = "Board",
                            Name = "Splendor",
                            PlayTime = "30 Minutes",
                            PlayerAges = "10+",
                            PlayerMaximum = 4,
                            PlayerMinimum = 2,
                            ReleaseYear = 2014
                        },
                        new
                        {
                            Id = 4,
                            GameCategory = "Board",
                            Name = "Ark Nova",
                            PlayTime = "90-150 Minutes",
                            PlayerAges = "14+",
                            PlayerMaximum = 4,
                            PlayerMinimum = 1,
                            ReleaseYear = 2021
                        },
                        new
                        {
                            Id = 5,
                            GameCategory = "Party",
                            Name = "Werewords",
                            PlayTime = "10 Minutes",
                            PlayerAges = "8+",
                            PlayerMaximum = 10,
                            PlayerMinimum = 4,
                            ReleaseYear = 2017
                        });
                });

            modelBuilder.Entity("ContemporaryProgrammingFinal.Models.TeamInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CollegeProgram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavoriteSeason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearInProgram")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BirthDate = new DateTime(2000, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology",
                            FavoriteSeason = "Summer",
                            FullName = "Tom McReynolds",
                            YearInProgram = "Senior"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(2003, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology",
                            FavoriteSeason = "Winter",
                            FullName = "Jackson Pinchot",
                            YearInProgram = "Sophomore"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(1992, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Software Development",
                            FavoriteSeason = "Fall",
                            FullName = "Audrey Perdew",
                            YearInProgram = "Senior"
                        },
                        new
                        {
                            Id = 4,
                            BirthDate = new DateTime(1986, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CollegeProgram = "Information Technology",
                            FavoriteSeason = "Summer",
                            FullName = "Anna Finkelman",
                            YearInProgram = "Sophmore"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}