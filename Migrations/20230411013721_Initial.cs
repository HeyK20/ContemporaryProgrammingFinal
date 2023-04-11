using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContemporaryProgrammingFinal.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    FullName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CollegeProgram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YearInProgram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FavoriteSeason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.FullName);
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "FullName", "BirthDate", "CollegeProgram", "FavoriteSeason", "YearInProgram" },
                values: new object[] { "Tom McReynolds", new DateTime(2023, 4, 10, 21, 37, 21, 686, DateTimeKind.Local).AddTicks(7779), "Information Technology", "Summer", "Senior" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
