using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PatientManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedPatientMedicalHistoryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "PandemicPatients",
                keyColumn: "PatientId",
                keyValue: 1,
                columns: new[] { "ConfirmedDate", "CreatedDate", "DateOfBirth", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 1, 15, 17, 20, 50, 383, DateTimeKind.Local).AddTicks(6516), new DateTime(2024, 1, 15, 17, 20, 50, 383, DateTimeKind.Local).AddTicks(6526), new DateTime(2024, 1, 15, 17, 20, 50, 383, DateTimeKind.Local).AddTicks(6518), new DateTime(2024, 1, 15, 17, 20, 50, 383, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.InsertData(
                table: "PatientMedicalHistories",
                columns: new[] { "PatientMedicalHistoryId", "DiagnosisSummary", "ExaminedBy", "ExaminedDate", "PatientId", "Remarks", "Treatments" },
                values: new object[] { 1, "Diagnosis summary", 1, new DateTime(2024, 1, 15, 17, 20, 50, 383, DateTimeKind.Local).AddTicks(6541), 1, "Remarks", "Treatments" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PatientMedicalHistories",
                keyColumn: "PatientMedicalHistoryId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "PandemicPatients",
                keyColumn: "PatientId",
                keyValue: 1,
                columns: new[] { "ConfirmedDate", "CreatedDate", "DateOfBirth", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 1, 15, 17, 16, 44, 260, DateTimeKind.Local).AddTicks(2455), new DateTime(2024, 1, 15, 17, 16, 44, 260, DateTimeKind.Local).AddTicks(2466), new DateTime(2024, 1, 15, 17, 16, 44, 260, DateTimeKind.Local).AddTicks(2456), new DateTime(2024, 1, 15, 17, 16, 44, 260, DateTimeKind.Local).AddTicks(2440) });
        }
    }
}
