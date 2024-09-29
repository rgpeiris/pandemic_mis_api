using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedVaccineAppointmentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ScheduledVaccinationCentres",
                keyColumn: "ScheduledVaccinationCentreId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2023, 12, 21, 16, 17, 12, 421, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.InsertData(
                table: "VaccineAppointments",
                columns: new[] { "VaccineAppointmentId", "Address", "Age", "BirthYear", "CreatedBy", "DateScheduled", "Gender", "IsRequiredReports", "NICNumber", "Name", "PhoneNumber", "Status", "TimeScheduled", "VaccinationCentreId" },
                values: new object[] { 1, "538/7 Aluthmawatha Road, Colombo", 32, 1991, "rgpeiris-927810379V", new DateTime(2023, 12, 21, 16, 17, 12, 421, DateTimeKind.Local).AddTicks(2800), "Female", false, "917283783V", "Janvi Fernando", "772523191", "SCHEDULED", "Forenoon", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VaccineAppointments",
                keyColumn: "VaccineAppointmentId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "ScheduledVaccinationCentres",
                keyColumn: "ScheduledVaccinationCentreId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2023, 12, 21, 16, 4, 59, 449, DateTimeKind.Local).AddTicks(3652));
        }
    }
}
