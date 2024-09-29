using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnToVaccineAppointmentsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "VaccineAppointments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PandemicVaccinations",
                keyColumn: "PandemicVaccinationId",
                keyValue: 1,
                columns: new[] { "DateOfVaccination", "NextAppointmentDate" },
                values: new object[] { new DateTime(2024, 1, 21, 18, 49, 45, 957, DateTimeKind.Local).AddTicks(8402), new DateTime(2024, 4, 20, 18, 49, 45, 957, DateTimeKind.Local).AddTicks(8403) });

            migrationBuilder.UpdateData(
                table: "ScheduledVaccinationCentres",
                keyColumn: "ScheduledVaccinationCentreId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2024, 1, 21, 18, 49, 45, 957, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "VaccineAppointments",
                keyColumn: "VaccineAppointmentId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateScheduled" },
                values: new object[] { new DateTime(2024, 1, 21, 18, 49, 45, 957, DateTimeKind.Local).AddTicks(8368), new DateTime(2024, 1, 21, 18, 49, 45, 957, DateTimeKind.Local).AddTicks(8367) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "VaccineAppointments");

            migrationBuilder.UpdateData(
                table: "PandemicVaccinations",
                keyColumn: "PandemicVaccinationId",
                keyValue: 1,
                columns: new[] { "DateOfVaccination", "NextAppointmentDate" },
                values: new object[] { new DateTime(2023, 12, 21, 16, 32, 11, 224, DateTimeKind.Local).AddTicks(9099), new DateTime(2024, 3, 20, 16, 32, 11, 224, DateTimeKind.Local).AddTicks(9099) });

            migrationBuilder.UpdateData(
                table: "ScheduledVaccinationCentres",
                keyColumn: "ScheduledVaccinationCentreId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2023, 12, 21, 16, 32, 11, 224, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "VaccineAppointments",
                keyColumn: "VaccineAppointmentId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2023, 12, 21, 16, 32, 11, 224, DateTimeKind.Local).AddTicks(9067));
        }
    }
}
