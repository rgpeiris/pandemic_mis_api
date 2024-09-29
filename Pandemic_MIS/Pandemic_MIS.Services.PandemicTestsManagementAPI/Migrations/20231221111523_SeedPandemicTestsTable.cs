using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedPandemicTestsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PandemicTests",
                columns: new[] { "PandemicTestId", "Description", "TestType" },
                values: new object[,]
                {
                    { 1, "Detects genetic material of a virus.", "Molecular (PCR)" },
                    { 2, "Detects proteins found on a virus.", "Antigen" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PandemicTests",
                keyColumn: "PandemicTestId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PandemicTests",
                keyColumn: "PandemicTestId",
                keyValue: 2);
        }
    }
}
