using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedTestCentresTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TestCentres",
                columns: new[] { "TestCentreId", "Address", "CentreName", "City", "District", "IsActive", "Latitude", "Longitude", "PhoneNumber" },
                values: new object[] { 1, "RW99+J9X, Makuluduwa Rd, Piliyandala", "MOH Office Piliyandala", "Piliyandala", "Colombo", true, 6.8018029999999996, 79.922684000000004, "0112708553" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TestCentres",
                keyColumn: "TestCentreId",
                keyValue: 1);
        }
    }
}
