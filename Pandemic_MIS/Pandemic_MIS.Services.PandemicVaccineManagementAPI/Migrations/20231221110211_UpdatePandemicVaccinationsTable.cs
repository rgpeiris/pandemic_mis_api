using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatePandemicVaccinationsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PandemicVaccinations",
                keyColumn: "PandemicVaccinationId",
                keyValue: 1,
                columns: new[] { "Address", "DateOfVaccination", "GramaNiladhariArea", "MOHArea", "NextAppointmentDate" },
                values: new object[] { "538/7 Aluthmawatha Road, Piliyandala", new DateTime(2023, 12, 21, 16, 32, 11, 224, DateTimeKind.Local).AddTicks(9099), "Grama Niladhari Area Piliyandala", "MOH Office Piliyandala", new DateTime(2024, 3, 20, 16, 32, 11, 224, DateTimeKind.Local).AddTicks(9099) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PandemicVaccinations",
                keyColumn: "PandemicVaccinationId",
                keyValue: 1,
                columns: new[] { "Address", "DateOfVaccination", "GramaNiladhariArea", "MOHArea", "NextAppointmentDate" },
                values: new object[] { "538/7 Aluthmawatha Road, Colombo", new DateTime(2023, 12, 21, 16, 27, 49, 192, DateTimeKind.Local).AddTicks(958), "", "", new DateTime(2024, 3, 20, 16, 27, 49, 192, DateTimeKind.Local).AddTicks(958) });

            migrationBuilder.UpdateData(
                table: "ScheduledVaccinationCentres",
                keyColumn: "ScheduledVaccinationCentreId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2023, 12, 21, 16, 27, 49, 192, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "VaccineAppointments",
                keyColumn: "VaccineAppointmentId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2023, 12, 21, 16, 27, 49, 192, DateTimeKind.Local).AddTicks(934));
        }
    }
}
