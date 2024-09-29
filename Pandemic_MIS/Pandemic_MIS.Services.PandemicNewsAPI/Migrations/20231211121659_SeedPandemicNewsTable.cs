using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pandemic_MIS.Services.PandemicNewsAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedPandemicNewsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PandemicNews",
                columns: new[] { "NewsId", "Description", "IsActive", "Priority", "Title" },
                values: new object[,]
                {
                    { 1, "Let's Stay Safe", true, 1, "Let's Stay Safe" },
                    { 2, "Know about COVID-19 Vaccine", true, 2, "Know about COVID-19 Vaccine" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PandemicNews",
                keyColumn: "NewsId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PandemicNews",
                keyColumn: "NewsId",
                keyValue: 2);
        }
    }
}
