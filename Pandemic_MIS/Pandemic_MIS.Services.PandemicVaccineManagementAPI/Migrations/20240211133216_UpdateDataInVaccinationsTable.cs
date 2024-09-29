using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataInVaccinationsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                columns: new[] { "CreatedBy", "CreatedDate", "DateScheduled" },
                values: new object[] { "au_uthpala", new DateTime(2024, 2, 11, 19, 2, 16, 104, DateTimeKind.Local).AddTicks(7546), new DateTime(2024, 2, 11, 19, 2, 16, 104, DateTimeKind.Local).AddTicks(7543) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "CreatedBy", "CreatedDate", "DateScheduled" },
                values: new object[] { "rgpeiris-927810379V", new DateTime(2024, 2, 11, 18, 59, 4, 907, DateTimeKind.Local).AddTicks(3881), new DateTime(2024, 2, 11, 18, 59, 4, 907, DateTimeKind.Local).AddTicks(3879) });
        }
    }
}
