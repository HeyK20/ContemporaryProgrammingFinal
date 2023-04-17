using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContemporaryProgrammingFinal.Migrations
{
    /// <inheritdoc />
    public partial class SecondGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 4, 16, 17, 30, 41, 844, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2023, 4, 16, 17, 30, 41, 844, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "BirthDate", "CollegeProgram", "FavoriteSeason", "FullName", "YearInProgram" },
                values: new object[] { 2, new DateTime(2023, 4, 16, 17, 30, 41, 844, DateTimeKind.Local).AddTicks(5631), "Information Technology", "Winter", "Jackson Pinchot", "Sophomore" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 4, 16, 13, 6, 15, 818, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2023, 4, 16, 13, 6, 15, 818, DateTimeKind.Local).AddTicks(8051));
        }
    }
}
