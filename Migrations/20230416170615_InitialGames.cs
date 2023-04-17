using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContemporaryProgrammingFinal.Migrations
{
    /// <inheritdoc />
    public partial class InitialGames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReleaseYear = table.Column<int>(type: "int", nullable: false),
                    GameCategory = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerMinimum = table.Column<int>(type: "int", nullable: false),
                    PlayerMaximum = table.Column<int>(type: "int", nullable: false),
                    PlayTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerAges = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "GameCategory", "Name", "PlayTime", "PlayerAges", "PlayerMaximum", "PlayerMinimum", "ReleaseYear" },
                values: new object[,]
                {
                    { 1, "Party", "Monikers", "30-60 Minutes", "17+", 16, 4, 2015 },
                    { 2, "Card", "Cat in the Box", "30-45 Minutes", "10+", 4, 3, 2020 },
                    { 3, "Board", "Splendor", "30 Minutes", "10+", 4, 2, 2014 }
                });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 4, 16, 13, 6, 15, 818, DateTimeKind.Local).AddTicks(8007));

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "BirthDate", "CollegeProgram", "FavoriteSeason", "FullName", "YearInProgram" },
                values: new object[] { 3, new DateTime(2023, 4, 16, 13, 6, 15, 818, DateTimeKind.Local).AddTicks(8051), "Software Development", "Fall", "Audrey Perdew", "Senior" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2023, 4, 13, 21, 55, 7, 96, DateTimeKind.Local).AddTicks(1149));
        }
    }
}
