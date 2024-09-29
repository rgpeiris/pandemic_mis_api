using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedPandemicVaccinesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PandemicVaccines",
                columns: new[] { "VaccineId", "Dose", "NextDose", "VaccineName" },
                values: new object[,]
                {
                    { 1, "1st Dose", 3, "Sinopharm" },
                    { 2, "1st Dose", 3, "Pfizer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PandemicVaccines",
                keyColumn: "VaccineId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PandemicVaccines",
                keyColumn: "VaccineId",
                keyValue: 2);
        }
    }
}
