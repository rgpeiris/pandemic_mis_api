using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataVaccinationsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PandemicVaccinations",
                keyColumn: "PandemicVaccinationId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DateOfVaccination", "NextAppointmentDate" },
                values: new object[] { "hp_anushka", new DateTime(2024, 2, 11, 19, 11, 23, 83, DateTimeKind.Local).AddTicks(2975), new DateTime(2024, 2, 11, 19, 11, 23, 83, DateTimeKind.Local).AddTicks(2960), new DateTime(2024, 5, 11, 19, 11, 23, 83, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "PandemicVaccines",
                keyColumn: "VaccineId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 19, 11, 23, 83, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "PandemicVaccines",
                keyColumn: "VaccineId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 19, 11, 23, 83, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "ScheduledVaccinationCentres",
                keyColumn: "ScheduledVaccinationCentreId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateScheduled" },
                values: new object[] { new DateTime(2024, 2, 11, 19, 11, 23, 83, DateTimeKind.Local).AddTicks(2917), new DateTime(2024, 2, 11, 19, 11, 23, 83, DateTimeKind.Local).AddTicks(2915) });

            migrationBuilder.UpdateData(
                table: "VaccinationCentres",
                keyColumn: "VaccinationCentreId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 19, 11, 23, 83, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "VaccineAppointments",
                keyColumn: "VaccineAppointmentId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateScheduled" },
                values: new object[] { new DateTime(2024, 2, 11, 19, 11, 23, 83, DateTimeKind.Local).AddTicks(2938), new DateTime(2024, 2, 11, 19, 11, 23, 83, DateTimeKind.Local).AddTicks(2936) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PandemicVaccinations",
                keyColumn: "PandemicVaccinationId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate", "DateOfVaccination", "NextAppointmentDate" },
                values: new object[] { "au_uthpala", new DateTime(2024, 2, 11, 19, 2, 16, 104, DateTimeKind.Local).AddTicks(7616), new DateTime(2024, 2, 11, 19, 2, 16, 104, DateTimeKind.Local).AddTicks(7591), new DateTime(2024, 5, 11, 19, 2, 16, 104, DateTimeKind.Local).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "PandemicVaccines",
                keyColumn: "VaccineId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 19, 2, 16, 104, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "PandemicVaccines",
                keyColumn: "VaccineId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 19, 2, 16, 104, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "ScheduledVaccinationCentres",
                keyColumn: "ScheduledVaccinationCentreId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateScheduled" },
                values: new object[] { new DateTime(2024, 2, 11, 19, 2, 16, 104, DateTimeKind.Local).AddTicks(7504), new DateTime(2024, 2, 11, 19, 2, 16, 104, DateTimeKind.Local).AddTicks(7501) });

            migrationBuilder.UpdateData(
                table: "VaccinationCentres",
                keyColumn: "VaccinationCentreId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 11, 19, 2, 16, 104, DateTimeKind.Local).AddTicks(7463));

            migrationBuilder.UpdateData(
                table: "VaccineAppointments",
                keyColumn: "VaccineAppointmentId",
                keyValue: 1,
                columns: new[] { "CreatedDate", "DateScheduled" },
                values: new object[] { new DateTime(2024, 2, 11, 19, 2, 16, 104, DateTimeKind.Local).AddTicks(7546), new DateTime(2024, 2, 11, 19, 2, 16, 104, DateTimeKind.Local).AddTicks(7543) });
        }
    }
}
