using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PatientManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsTo3TablesInPatientMgt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "LocalGovernmentInCharge",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "LocalGovernmentInCharge",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Hospitals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Hospitals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "HealthcareProfessionals",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "HealthcareProfessionals",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "HealthcareProfessionals",
                keyColumn: "HealthcareProfessionalId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { "ad_rpeiris", new DateTime(2024, 1, 31, 13, 11, 46, 511, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "HospitalId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { "ad_rpeiris", new DateTime(2024, 1, 31, 13, 11, 46, 511, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "LocalGovernmentInCharge",
                keyColumn: "LocalGovernmentInChargeId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { "ad_rpeiris", new DateTime(2024, 1, 31, 13, 11, 46, 511, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "PandemicPatients",
                keyColumn: "PatientId",
                keyValue: 1,
                columns: new[] { "ConfirmedDate", "CreatedDate", "DateOfBirth", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 1, 31, 13, 11, 46, 511, DateTimeKind.Local).AddTicks(3708), new DateTime(2024, 1, 31, 13, 11, 46, 511, DateTimeKind.Local).AddTicks(3719), new DateTime(2024, 1, 31, 13, 11, 46, 511, DateTimeKind.Local).AddTicks(3709), new DateTime(2024, 1, 31, 13, 11, 46, 511, DateTimeKind.Local).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "PatientMedicalHistories",
                keyColumn: "PatientMedicalHistoryId",
                keyValue: 1,
                column: "ExaminedDate",
                value: new DateTime(2024, 1, 31, 13, 11, 46, 511, DateTimeKind.Local).AddTicks(3736));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "LocalGovernmentInCharge");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "LocalGovernmentInCharge");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Hospitals");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "HealthcareProfessionals");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "HealthcareProfessionals");

            migrationBuilder.UpdateData(
                table: "PandemicPatients",
                keyColumn: "PatientId",
                keyValue: 1,
                columns: new[] { "ConfirmedDate", "CreatedDate", "DateOfBirth", "RegistrationDate" },
                values: new object[] { new DateTime(2024, 1, 15, 17, 20, 50, 383, DateTimeKind.Local).AddTicks(6516), new DateTime(2024, 1, 15, 17, 20, 50, 383, DateTimeKind.Local).AddTicks(6526), new DateTime(2024, 1, 15, 17, 20, 50, 383, DateTimeKind.Local).AddTicks(6518), new DateTime(2024, 1, 15, 17, 20, 50, 383, DateTimeKind.Local).AddTicks(6505) });

            migrationBuilder.UpdateData(
                table: "PatientMedicalHistories",
                keyColumn: "PatientMedicalHistoryId",
                keyValue: 1,
                column: "ExaminedDate",
                value: new DateTime(2024, 1, 15, 17, 20, 50, 383, DateTimeKind.Local).AddTicks(6541));
        }
    }
}
