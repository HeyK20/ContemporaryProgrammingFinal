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
    [Migration("20230411013721_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ContemporaryProgrammingFinal.Models.TeamInfo", b =>
                {
                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CollegeProgram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FavoriteSeason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("YearInProgram")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FullName");

                    b.ToTable("Members");

                    b.HasData(
                        new
                        {
                            FullName = "Tom McReynolds",
                            BirthDate = new DateTime(2023, 4, 10, 21, 37, 21, 686, DateTimeKind.Local).AddTicks(7779),
                            CollegeProgram = "Information Technology",
                            FavoriteSeason = "Summer",
                            YearInProgram = "Senior"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
