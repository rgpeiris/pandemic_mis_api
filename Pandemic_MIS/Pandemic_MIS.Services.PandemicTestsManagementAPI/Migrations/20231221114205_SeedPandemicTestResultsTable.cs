using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedPandemicTestResultsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PandemicTestResults",
                columns: new[] { "PandemicTestResultId", "Address", "Age", "DateOfPandemicTest", "District", "Gender", "GramaNiladhariArea", "MOHArea", "NICNumber", "Name", "PhoneNumber", "SerialNumber", "Status", "TestCentreId", "TestResult", "TestResultSummary" },
                values: new object[] { 1, "538/7 Aluthmawatha Road, Piliyandala", 32, new DateTime(2023, 12, 21, 17, 12, 4, 955, DateTimeKind.Local).AddTicks(7081), "Colombo", "Female", "Grama Niladhari Area Piliyandala", "MOH Office Piliyandala", "917283783V", "Janvi Fernando", "772523191", 1, "ISOLATION", 1, "Positive", "Positive" });

            migrationBuilder.UpdateData(
                table: "ScheduledTestCentres",
                keyColumn: "ScheduledTestCentreId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2023, 12, 21, 17, 12, 4, 955, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "TestsAppointments",
                keyColumn: "TestsAppointmentId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2023, 12, 21, 17, 12, 4, 955, DateTimeKind.Local).AddTicks(7062));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PandemicTestResults",
                keyColumn: "PandemicTestResultId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "ScheduledTestCentres",
                keyColumn: "ScheduledTestCentreId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2023, 12, 21, 16, 58, 42, 668, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "TestsAppointments",
                keyColumn: "TestsAppointmentId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2023, 12, 21, 16, 58, 42, 668, DateTimeKind.Local).AddTicks(2805));
        }
    }
}
