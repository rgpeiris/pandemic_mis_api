using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnToTestsAppointmentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TestsAppointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PandemicTestResults",
                keyColumn: "PandemicTestResultId",
                keyValue: 1,
                column: "DateOfPandemicTest",
                value: new DateTime(2024, 1, 21, 20, 8, 55, 937, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "ScheduledTestCentres",
                keyColumn: "ScheduledTestCentreId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2024, 1, 21, 20, 8, 55, 937, DateTimeKind.Local).AddTicks(5055));

            migrationBuilder.UpdateData(
                table: "TestsAppointments",
                keyColumn: "TestsAppointmentId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DateScheduled" },
                values: new object[] { "ad_rgpeiris", new DateTime(2024, 1, 21, 20, 8, 55, 937, DateTimeKind.Local).AddTicks(5165), new DateTime(2024, 1, 21, 20, 8, 55, 937, DateTimeKind.Local).AddTicks(5162) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TestsAppointments");

            migrationBuilder.UpdateData(
                table: "PandemicTestResults",
                keyColumn: "PandemicTestResultId",
                keyValue: 1,
                column: "DateOfPandemicTest",
                value: new DateTime(2023, 12, 21, 17, 12, 4, 955, DateTimeKind.Local).AddTicks(7081));

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
                columns: new[] { "CreatedBy", "DateScheduled" },
                values: new object[] { "rgpeiris-927810379V", new DateTime(2023, 12, 21, 17, 12, 4, 955, DateTimeKind.Local).AddTicks(7062) });
        }
    }
}
