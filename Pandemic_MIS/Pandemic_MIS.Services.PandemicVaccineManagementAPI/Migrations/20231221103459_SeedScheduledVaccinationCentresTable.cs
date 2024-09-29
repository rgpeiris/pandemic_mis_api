using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedScheduledVaccinationCentresTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ScheduledVaccinationCentres",
                columns: new[] { "ScheduledVaccinationCentreId", "AvailableCapacity", "DateScheduled", "TimeScheduled", "VaccinationCentreId" },
                values: new object[] { 1, 500, new DateTime(2023, 12, 21, 16, 4, 59, 449, DateTimeKind.Local).AddTicks(3652), "Forenoon", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ScheduledVaccinationCentres",
                keyColumn: "ScheduledVaccinationCentreId",
                keyValue: 1);
        }
    }
}
