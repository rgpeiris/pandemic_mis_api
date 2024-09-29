using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedTestsAppointmentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ScheduledTestCentres",
                keyColumn: "ScheduledTestCentreId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2023, 12, 21, 16, 58, 42, 668, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.InsertData(
                table: "TestsAppointments",
                columns: new[] { "TestsAppointmentId", "Address", "Age", "CreatedBy", "DateScheduled", "Gender", "NICNumber", "Name", "PhoneNumber", "Status", "TestCentreId", "TimeScheduled" },
                values: new object[] { 1, "538/7 Aluthmawatha Road, Colombo", 32, "rgpeiris-927810379V", new DateTime(2023, 12, 21, 16, 58, 42, 668, DateTimeKind.Local).AddTicks(2805), "Female", "917283783V", "Janvi Fernando", "772523191", "SCHEDULED", 1, "Forenoon" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TestsAppointments",
                keyColumn: "TestsAppointmentId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "ScheduledTestCentres",
                keyColumn: "ScheduledTestCentreId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2023, 12, 21, 16, 53, 45, 3, DateTimeKind.Local).AddTicks(4870));
        }
    }
}
