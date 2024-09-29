using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsToVaccinationsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PandemicVaccinations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "PandemicVaccinations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PandemicVaccinations",
                keyColumn: "PandemicVaccinationId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DateOfVaccination", "NextAppointmentDate" },
                values: new object[] { "rgpeiris-927810379V", new DateTime(2024, 2, 11, 18, 59, 4, 907, DateTimeKind.Local).AddTicks(3925), new DateTime(2024, 2, 11, 18, 59, 4, 907, DateTimeKind.Local).AddTicks(3908), new DateTime(2024, 5, 11, 18, 59, 4, 907, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "PandemicVaccines",
                keyColumn: "VaccineId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 18, 59, 4, 907, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "PandemicVaccines",
                keyColumn: "VaccineId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 18, 59, 4, 907, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "ScheduledVaccinationCentres",
                keyColumn: "ScheduledVaccinationCentreId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateScheduled" },
                values: new object[] { new DateTime(2024, 2, 11, 18, 59, 4, 907, DateTimeKind.Local).AddTicks(3857), new DateTime(2024, 2, 11, 18, 59, 4, 907, DateTimeKind.Local).AddTicks(3854) });

            migrationBuilder.UpdateData(
                table: "VaccinationCentres",
                keyColumn: "VaccinationCentreId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 18, 59, 4, 907, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "VaccineAppointments",
                keyColumn: "VaccineAppointmentId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateScheduled" },
                values: new object[] { new DateTime(2024, 2, 11, 18, 59, 4, 907, DateTimeKind.Local).AddTicks(3881), new DateTime(2024, 2, 11, 18, 59, 4, 907, DateTimeKind.Local).AddTicks(3879) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PandemicVaccinations");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "PandemicVaccinations");

            migrationBuilder.UpdateData(
                table: "PandemicVaccinations",
                keyColumn: "PandemicVaccinationId",
                keyValue: 1,
                columns: new[] { "DateOfVaccination", "NextAppointmentDate" },
                values: new object[] { new DateTime(2024, 2, 11, 18, 48, 21, 993, DateTimeKind.Local).AddTicks(1761), new DateTime(2024, 5, 11, 18, 48, 21, 993, DateTimeKind.Local).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "PandemicVaccines",
                keyColumn: "VaccineId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 18, 48, 21, 993, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "PandemicVaccines",
                keyColumn: "VaccineId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 18, 48, 21, 993, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "ScheduledVaccinationCentres",
                keyColumn: "ScheduledVaccinationCentreId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateScheduled" },
                values: new object[] { new DateTime(2024, 2, 11, 18, 48, 21, 993, DateTimeKind.Local).AddTicks(1711), new DateTime(2024, 2, 11, 18, 48, 21, 993, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "VaccinationCentres",
                keyColumn: "VaccinationCentreId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 18, 48, 21, 993, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "VaccineAppointments",
                keyColumn: "VaccineAppointmentId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateScheduled" },
                values: new object[] { new DateTime(2024, 2, 11, 18, 48, 21, 993, DateTimeKind.Local).AddTicks(1734), new DateTime(2024, 2, 11, 18, 48, 21, 993, DateTimeKind.Local).AddTicks(1732) });
        }
    }
}
