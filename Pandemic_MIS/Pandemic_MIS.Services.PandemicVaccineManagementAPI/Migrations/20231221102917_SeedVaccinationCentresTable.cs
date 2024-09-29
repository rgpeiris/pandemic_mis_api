using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVaccinationCentresTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "VaccinationCentres",
                columns: new[] { "VaccinationCentreId", "Address", "CentreName", "City", "District", "IsActive", "Latitude", "Longitude", "PhoneNumber" },
                values: new object[] { 1, "RW99+J9X, Makuluduwa Rd, Piliyandala", "MOH Office Piliyandala", "Piliyandala", "Colombo", true, 6.8018029999999996, 79.922684000000004, "0112 708 553" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VaccinationCentres",
                keyColumn: "VaccinationCentreId",
                keyValue: 1);
        }
    }
}
