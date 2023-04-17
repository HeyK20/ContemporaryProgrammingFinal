using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContemporaryProgrammingFinal.Migrations
{
    /// <inheritdoc />
    public partial class Games5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GameCategory", "Name", "PlayTime", "PlayerAges", "PlayerMaximum", "PlayerMinimum", "ReleaseYear" },
                values: new object[,]
                {
                    { 4, "Board", "Ark Nova", "90-150 Minutes", "14+", 4, 1, 2021 },
                    { 5, "Party", "Werewords", "10 Minutes", "8+", 10, 4, 2017 }
                });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 4, 16, 22, 4, 36, 712, DateTimeKind.Local).AddTicks(133));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2023, 4, 16, 22, 4, 36, 712, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2023, 4, 16, 22, 4, 36, 712, DateTimeKind.Local).AddTicks(180));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 4, 16, 21, 49, 55, 713, DateTimeKind.Local).AddTicks(2354));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2023, 4, 16, 21, 49, 55, 713, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(2023, 4, 16, 21, 49, 55, 713, DateTimeKind.Local).AddTicks(2407));
        }
    }
}
