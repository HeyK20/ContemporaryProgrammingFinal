using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContemporaryProgrammingFinal.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Members",
                table: "Members");

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "FullName",
                keyValue: "Tom McReynolds");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Members",
                table: "Members",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "BirthDate", "CollegeProgram", "FavoriteSeason", "FullName", "YearInProgram" },
                values: new object[] { 1, new DateTime(2023, 4, 11, 17, 40, 0, 772, DateTimeKind.Local).AddTicks(6309), "Information Technology", "Summer", "Tom McReynolds", "Senior" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Members",
                table: "Members");

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Members");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Members",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Members",
                table: "Members",
                column: "FullName");

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "FullName", "BirthDate", "CollegeProgram", "FavoriteSeason", "YearInProgram" },
                values: new object[] { "Tom McReynolds", new DateTime(2023, 4, 10, 21, 37, 21, 686, DateTimeKind.Local).AddTicks(7779), "Information Technology", "Summer", "Senior" });
        }
    }
}
