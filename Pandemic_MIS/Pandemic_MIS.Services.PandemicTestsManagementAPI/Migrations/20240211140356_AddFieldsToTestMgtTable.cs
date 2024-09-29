using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicTestsManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsToTestMgtTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "TestCentres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "TestCentres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ScheduledTestCentres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "ScheduledTestCentres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PandemicTests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "PandemicTests",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PandemicTestResults",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "PandemicTestResults",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PandemicTestResults",
                keyColumn: "PandemicTestResultId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DateOfPandemicTest" },
                values: new object[] { "hp_anushka", new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5951), new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "PandemicTests",
                keyColumn: "PandemicTestId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { "hp_anushka", new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5807) });

            migrationBuilder.UpdateData(
                table: "PandemicTests",
                keyColumn: "PandemicTestId",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { "hp_anushka", new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "ScheduledTestCentres",
                keyColumn: "ScheduledTestCentreId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DateScheduled" },
                values: new object[] { "hp_anushka", new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5906), new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "TestCentres",
                keyColumn: "TestCentreId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { "hp_anushka", new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "TestsAppointments",
                keyColumn: "TestsAppointmentId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DateScheduled" },
                values: new object[] { "au_uthpala", new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5929), new DateTime(2024, 2, 11, 19, 33, 55, 594, DateTimeKind.Local).AddTicks(5927) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "TestCentres");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "TestCentres");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ScheduledTestCentres");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "ScheduledTestCentres");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PandemicTests");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "PandemicTests");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PandemicTestResults");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "PandemicTestResults");

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
    }
}
