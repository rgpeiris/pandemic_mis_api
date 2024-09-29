using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PatientManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDataTypesInPatientTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PassportNumber",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "OtherMedicalNotes",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "DateOfBirth",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "CriticalMedicalInformation",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "HealthcareProfessionals",
                keyColumn: "HealthcareProfessionalId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 16, 41, 49, 124, DateTimeKind.Local).AddTicks(4950));

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "HospitalId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 16, 41, 49, 124, DateTimeKind.Local).AddTicks(5155));

            migrationBuilder.UpdateData(
                table: "LocalGovernmentInCharge",
                keyColumn: "LocalGovernmentInChargeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 16, 41, 49, 124, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "PandemicPatients",
                keyColumn: "PatientId",
                keyValue: 1,
                columns: new[] { "ConfirmedDate", "CreatedDate", "CriticalMedicalInformation", "DateOfBirth", "OtherMedicalNotes", "PassportNumber", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 2, 3, 16, 41, 49, 124, DateTimeKind.Local).AddTicks(5215), new DateTime(2024, 2, 3, 16, 41, 49, 124, DateTimeKind.Local).AddTicks(5229), null, "1991-January-2", null, null, new DateTime(2024, 2, 3, 16, 41, 49, 124, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "PatientMedicalHistories",
                keyColumn: "PatientMedicalHistoryId",
                keyValue: 1,
                column: "ExaminedDate",
                value: new DateTime(2024, 2, 3, 16, 41, 49, 124, DateTimeKind.Local).AddTicks(5253));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PassportNumber",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OtherMedicalNotes",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfBirth",
                table: "PandemicPatients",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CriticalMedicalInformation",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "HealthcareProfessionals",
                keyColumn: "HealthcareProfessionalId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 13, 45, 35, 129, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "HospitalId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 13, 45, 35, 129, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "LocalGovernmentInCharge",
                keyColumn: "LocalGovernmentInChargeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 13, 45, 35, 129, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "PandemicPatients",
                keyColumn: "PatientId",
                keyValue: 1,
                columns: new[] { "ConfirmedDate", "CreatedDate", "CriticalMedicalInformation", "DateOfBirth", "OtherMedicalNotes", "PassportNumber", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 2, 3, 13, 45, 35, 129, DateTimeKind.Local).AddTicks(6062), new DateTime(2024, 2, 3, 13, 45, 35, 129, DateTimeKind.Local).AddTicks(6074), "N/A", new DateTime(2024, 2, 3, 13, 45, 35, 129, DateTimeKind.Local).AddTicks(6064), "N/A", "N7464213", new DateTime(2024, 2, 3, 13, 45, 35, 129, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "PatientMedicalHistories",
                keyColumn: "PatientMedicalHistoryId",
                keyValue: 1,
                column: "ExaminedDate",
                value: new DateTime(2024, 2, 3, 13, 45, 35, 129, DateTimeKind.Local).AddTicks(6090));
        }
    }
}
