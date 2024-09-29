using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsToVaccinationCentresTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "VaccinationCentres",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "VaccinationCentres",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PandemicVaccinations",
                keyColumn: "PandemicVaccinationId",
                keyValue: 1,
                columns: new[] { "DateOfVaccination", "NextAppointmentDate" },
                values: new object[] { new DateTime(2024, 2, 11, 18, 40, 15, 393, DateTimeKind.Local).AddTicks(1402), new DateTime(2024, 5, 11, 18, 40, 15, 393, DateTimeKind.Local).AddTicks(1403) });

            migrationBuilder.UpdateData(
                table: "PandemicVaccines",
                keyColumn: "VaccineId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 18, 40, 15, 393, DateTimeKind.Local).AddTicks(1277));

            migrationBuilder.UpdateData(
                table: "PandemicVaccines",
                keyColumn: "VaccineId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 18, 40, 15, 393, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "ScheduledVaccinationCentres",
                keyColumn: "ScheduledVaccinationCentreId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2024, 2, 11, 18, 40, 15, 393, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "VaccinationCentres",
                keyColumn: "VaccinationCentreId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { "hp_anushka", new DateTime(2024, 2, 11, 18, 40, 15, 393, DateTimeKind.Local).AddTicks(1342) });

            migrationBuilder.UpdateData(
                table: "VaccineAppointments",
                keyColumn: "VaccineAppointmentId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateScheduled" },
                values: new object[] { new DateTime(2024, 2, 11, 18, 40, 15, 393, DateTimeKind.Local).AddTicks(1380), new DateTime(2024, 2, 11, 18, 40, 15, 393, DateTimeKind.Local).AddTicks(1379) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "VaccinationCentres");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "VaccinationCentres");

            migrationBuilder.UpdateData(
                table: "PandemicVaccinations",
                keyColumn: "PandemicVaccinationId",
                keyValue: 1,
                columns: new[] { "DateOfVaccination", "NextAppointmentDate" },
                values: new object[] { new DateTime(2024, 2, 11, 18, 29, 34, 210, DateTimeKind.Local).AddTicks(468), new DateTime(2024, 5, 11, 18, 29, 34, 210, DateTimeKind.Local).AddTicks(470) });

            migrationBuilder.UpdateData(
                table: "PandemicVaccines",
                keyColumn: "VaccineId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 18, 29, 34, 210, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "PandemicVaccines",
                keyColumn: "VaccineId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 18, 29, 34, 210, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "ScheduledVaccinationCentres",
                keyColumn: "ScheduledVaccinationCentreId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2024, 2, 11, 18, 29, 34, 210, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "VaccineAppointments",
                keyColumn: "VaccineAppointmentId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateScheduled" },
                values: new object[] { new DateTime(2024, 2, 11, 18, 29, 34, 210, DateTimeKind.Local).AddTicks(414), new DateTime(2024, 2, 11, 18, 29, 34, 210, DateTimeKind.Local).AddTicks(410) });
        }
    }
}
