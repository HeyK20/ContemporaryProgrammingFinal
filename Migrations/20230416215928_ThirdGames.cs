using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContemporaryProgrammingFinal.Migrations
{
    /// <inheritdoc />
    public partial class ThirdGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 4, 16, 17, 59, 28, 92, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2023, 4, 16, 17, 59, 28, 92, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2023, 4, 16, 17, 59, 28, 92, DateTimeKind.Local).AddTicks(2275));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2023, 4, 16, 17, 30, 41, 844, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2023, 4, 16, 17, 30, 41, 844, DateTimeKind.Local).AddTicks(5634));
        }
    }
}
