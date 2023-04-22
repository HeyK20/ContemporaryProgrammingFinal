using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContemporaryProgrammingFinal.Migrations
{
    /// <inheritdoc />
    public partial class eight : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "Calories", "Cold", "FatContent", "Hot", "Name", "Refridgerated" },
                values: new object[,]
                {
                    { 2, 100, "n", 4, "y", "Pancakes", "n" },
                    { 3, 70, "n", 7, "y", "Bacon", "n" },
                    { 4, 150, "y", 3, "n", "Cereal", "n" },
                    { 5, 85, "n", 4, "y", "Sausage", "n" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "BirthDate", "CollegeProgram", "FavoriteSeason", "FullName", "YearInProgram" },
                values: new object[] { 4, new DateTime(1986, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "Summer", "Anna Finkelman", "Sophmore" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
