using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedPandemicVaccinationTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PandemicVaccinations",
                columns: new[] { "PandemicVaccinationId", "Address", "Age", "DateOfVaccination", "District", "Gender", "GramaNiladhariArea", "MOHArea", "NICNumber", "Name", "NextAppointmentDate", "PhoneNumber", "SerialNumber", "VaccinationCentreId", "VaccineDose", "VaccineName" },
                values: new object[] { 1, "538/7 Aluthmawatha Road, Colombo", 32, new DateTime(2023, 12, 21, 16, 27, 49, 192, DateTimeKind.Local).AddTicks(958), "Colombo", "Female", "", "", "917283783V", "Janvi Fernando", new DateTime(2024, 3, 20, 16, 27, 49, 192, DateTimeKind.Local).AddTicks(958), "772523191", 1, 1, "1st Dose", "Sinopharm" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PandemicVaccinations",
                keyColumn: "PandemicVaccinationId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "ScheduledVaccinationCentres",
                keyColumn: "ScheduledVaccinationCentreId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2023, 12, 21, 16, 17, 12, 421, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "VaccineAppointments",
                keyColumn: "VaccineAppointmentId",
                keyValue: 1,
                column: "DateScheduled",
                value: new DateTime(2023, 12, 21, 16, 17, 12, 421, DateTimeKind.Local).AddTicks(2800));
        }
    }
}
