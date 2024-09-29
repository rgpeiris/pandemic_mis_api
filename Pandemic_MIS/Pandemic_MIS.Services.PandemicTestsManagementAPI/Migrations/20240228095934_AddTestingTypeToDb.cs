using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddTestingTypeToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TestingType",
                table: "PandemicTestResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "PandemicTestResults",
                keyColumn: "PandemicTestResultId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateOfPandemicTest", "TestingType" },
                values: new object[] { new DateTime(2024, 2, 28, 15, 29, 34, 168, DateTimeKind.Local).AddTicks(8536), new DateTime(2024, 2, 28, 15, 29, 34, 168, DateTimeKind.Local).AddTicks(8534), "Molecular (PCR)" });

            migrationBuilder.UpdateData(
                table: "PandemicTests",
                keyColumn: "PandemicTestId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 15, 29, 34, 168, DateTimeKind.Local).AddTicks(8356));

            migrationBuilder.UpdateData(
                table: "PandemicTests",
                keyColumn: "PandemicTestId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 15, 29, 34, 168, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "ScheduledTestCentres",
                keyColumn: "ScheduledTestCentreId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateScheduled" },
                values: new object[] { new DateTime(2024, 2, 28, 15, 29, 34, 168, DateTimeKind.Local).AddTicks(8481), new DateTime(2024, 2, 28, 15, 29, 34, 168, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "TestCentres",
                keyColumn: "TestCentreId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 28, 15, 29, 34, 168, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "TestsAppointments",
                keyColumn: "TestsAppointmentId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateScheduled" },
                values: new object[] { new DateTime(2024, 2, 28, 15, 29, 34, 168, DateTimeKind.Local).AddTicks(8509), new DateTime(2024, 2, 28, 15, 29, 34, 168, DateTimeKind.Local).AddTicks(8507) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestingType",
                table: "PandemicTestResults");

            migrationBuilder.UpdateData(
                table: "PandemicTestResults",
                keyColumn: "PandemicTestResultId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateOfPandemicTest" },
                values: new object[] { new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5951), new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "PandemicTests",
                keyColumn: "PandemicTestId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5807));

            migrationBuilder.UpdateData(
                table: "PandemicTests",
                keyColumn: "PandemicTestId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "ScheduledTestCentres",
                keyColumn: "ScheduledTestCentreId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateScheduled" },
                values: new object[] { new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5906), new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "TestCentres",
                keyColumn: "TestCentreId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "TestsAppointments",
                keyColumn: "TestsAppointmentId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateScheduled" },
                values: new object[] { new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5929), new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5927) });
        }
    }
}
