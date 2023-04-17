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
    [Migration("20230416215928_ThirdGames")]
    partial class ThirdGames
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
                            BirthDate = new DateTime(2023, 4, 16, 17, 59, 28, 92, DateTimeKind.Local).AddTicks(2197),
                            CollegeProgram = "Information Technology",
                            FavoriteSeason = "Summer",
                            FullName = "Tom McReynolds",
                            YearInProgram = "Senior"
                        },
                        new
                        {
                            Id = 2,
                            BirthDate = new DateTime(2023, 4, 16, 17, 59, 28, 92, DateTimeKind.Local).AddTicks(2271),
                            CollegeProgram = "Information Technology",
                            FavoriteSeason = "Winter",
                            FullName = "Jackson Pinchot",
                            YearInProgram = "Sophomore"
                        },
                        new
                        {
                            Id = 3,
                            BirthDate = new DateTime(2023, 4, 16, 17, 59, 28, 92, DateTimeKind.Local).AddTicks(2275),
                            CollegeProgram = "Software Development",
                            FavoriteSeason = "Fall",
                            FullName = "Audrey Perdew",
                            YearInProgram = "Senior"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
