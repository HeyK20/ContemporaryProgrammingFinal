using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContemporaryProgrammingFinal.Migrations
{
    /// <inheritdoc />
    public partial class nine : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakeModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrimLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Color", "MakeModel", "ManufacturerYear", "TrimLevel", "Type" },
                values: new object[,]
                {
                    { 1, "Black", "Honda Civic", "2017", "Sport", "Hatchback" },
                    { 2, "White", "Toyota Corola", "2022", "SE", "Sedan" },
                    { 3, "Blue", "Ford Fusion", "2020", "SEL", "Sedan" },
                    { 4, "Red", "Chevy Cruze", "2019", "LT", "Sedan" },
                    { 5, "Gray", "Tesla Model Y", "2023", "Fully Autonomous", "SUV" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
