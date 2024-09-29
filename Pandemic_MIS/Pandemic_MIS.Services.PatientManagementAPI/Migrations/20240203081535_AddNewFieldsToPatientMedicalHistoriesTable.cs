using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PatientManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddNewFieldsToPatientMedicalHistoriesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "PatientMedicalHistories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ExaminedBy",
                table: "PatientMedicalHistories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                columns: new[] { "ConfirmedDate", "CreatedDate", "DateOfBirth", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 2, 3, 13, 45, 35, 129, DateTimeKind.Local).AddTicks(6062), new DateTime(2024, 2, 3, 13, 45, 35, 129, DateTimeKind.Local).AddTicks(6074), new DateTime(2024, 2, 3, 13, 45, 35, 129, DateTimeKind.Local).AddTicks(6064), new DateTime(2024, 2, 3, 13, 45, 35, 129, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "PatientMedicalHistories",
                keyColumn: "PatientMedicalHistoryId",
                keyValue: 1,
                columns: new[] { "ExaminedBy", "ExaminedDate" },
                values: new object[] { "hp_aweerasinghe", new DateTime(2024, 2, 3, 13, 45, 35, 129, DateTimeKind.Local).AddTicks(6090) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "PatientMedicalHistories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ExaminedBy",
                table: "PatientMedicalHistories",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "HealthcareProfessionals",
                keyColumn: "HealthcareProfessionalId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 13, 38, 7, 954, DateTimeKind.Local).AddTicks(3469));

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "HospitalId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 13, 38, 7, 954, DateTimeKind.Local).AddTicks(3601));

            migrationBuilder.UpdateData(
                table: "LocalGovernmentInCharge",
                keyColumn: "LocalGovernmentInChargeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 2, 3, 13, 38, 7, 954, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "PandemicPatients",
                keyColumn: "PatientId",
                keyValue: 1,
                columns: new[] { "ConfirmedDate", "CreatedDate", "DateOfBirth", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 2, 3, 13, 38, 7, 954, DateTimeKind.Local).AddTicks(3642), new DateTime(2024, 2, 3, 13, 38, 7, 954, DateTimeKind.Local).AddTicks(3653), new DateTime(2024, 2, 3, 13, 38, 7, 954, DateTimeKind.Local).AddTicks(3644), new DateTime(2024, 2, 3, 13, 38, 7, 954, DateTimeKind.Local).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "PatientMedicalHistories",
                keyColumn: "PatientMedicalHistoryId",
                keyValue: 1,
                columns: new[] { "ExaminedBy", "ExaminedDate" },
                values: new object[] { 1, new DateTime(2024, 2, 3, 13, 38, 7, 954, DateTimeKind.Local).AddTicks(3670) });
        }
    }
}
