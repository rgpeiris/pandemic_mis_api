using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PatientManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddNewFieldsToPatientTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WardNumber",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "SeverityUponDiagnosis",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "SecondNegativeConfirmationDate",
                table: "PandemicPatients",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseInfoRemarks",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseInfoCertifiedBy",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "RecommendedTreatmentType",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LocalGovernmentInCharge",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HospitalId",
                table: "PandemicPatients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "HospitalAdmissionNo",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "HealthcareProfessionalInCharge",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FirstNegativeConfirmationDate",
                table: "PandemicPatients",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfRecovery",
                table: "PandemicPatients",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfHospitalization",
                table: "PandemicPatients",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfDeath",
                table: "PandemicPatients",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "BedNumber",
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
                columns: new[] { "BedNumber", "ConfirmedDate", "CreatedBy", "CreatedDate", "DateOfBirth", "DateOfDeath", "DateOfHospitalization", "DateOfRecovery", "FirstNegativeConfirmationDate", "GuardianPhoneNumber", "HealthcareProfessionalInCharge", "HospitalAdmissionNo", "HospitalId", "LocalGovernmentInCharge", "PhoneNumber", "RecommendedTreatmentType", "RegistrationDate", "ReleaseInfoCertifiedBy", "ReleaseInfoRemarks", "SecondNegativeConfirmationDate", "SeverityUponDiagnosis", "Status", "WardNumber" },
                values: new object[] { null, new DateTime(2024, 2, 3, 13, 38, 7, 954, DateTimeKind.Local).AddTicks(3642), "ad_rpeiris", new DateTime(2024, 2, 3, 13, 38, 7, 954, DateTimeKind.Local).AddTicks(3653), new DateTime(2024, 2, 3, 13, 38, 7, 954, DateTimeKind.Local).AddTicks(3644), null, null, null, null, "0772607755", "hp_aweerasinghe", null, null, "chp_tgamage", "0772601155", null, new DateTime(2024, 2, 3, 13, 38, 7, 954, DateTimeKind.Local).AddTicks(3641), null, null, null, null, "Registration Completed", null });

            migrationBuilder.UpdateData(
                table: "PatientMedicalHistories",
                keyColumn: "PatientMedicalHistoryId",
                keyValue: 1,
                column: "ExaminedDate",
                value: new DateTime(2024, 2, 3, 13, 38, 7, 954, DateTimeKind.Local).AddTicks(3670));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WardNumber",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SeverityUponDiagnosis",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "SecondNegativeConfirmationDate",
                table: "PandemicPatients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReleaseInfoRemarks",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ReleaseInfoCertifiedBy",
                table: "PandemicPatients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RecommendedTreatmentType",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LocalGovernmentInCharge",
                table: "PandemicPatients",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "HospitalId",
                table: "PandemicPatients",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HospitalAdmissionNo",
                table: "PandemicPatients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HealthcareProfessionalInCharge",
                table: "PandemicPatients",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FirstNegativeConfirmationDate",
                table: "PandemicPatients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfRecovery",
                table: "PandemicPatients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfHospitalization",
                table: "PandemicPatients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfDeath",
                table: "PandemicPatients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BedNumber",
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
                value: new DateTime(2024, 1, 31, 13, 11, 46, 511, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "Hospitals",
                keyColumn: "HospitalId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 31, 13, 11, 46, 511, DateTimeKind.Local).AddTicks(3654));

            migrationBuilder.UpdateData(
                table: "LocalGovernmentInCharge",
                keyColumn: "LocalGovernmentInChargeId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 31, 13, 11, 46, 511, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "PandemicPatients",
                keyColumn: "PatientId",
                keyValue: 1,
                columns: new[] { "BedNumber", "ConfirmedDate", "CreatedBy", "CreatedDate", "DateOfBirth", "DateOfDeath", "DateOfHospitalization", "DateOfRecovery", "FirstNegativeConfirmationDate", "GuardianPhoneNumber", "HealthcareProfessionalInCharge", "HospitalAdmissionNo", "HospitalId", "LocalGovernmentInCharge", "PhoneNumber", "RecommendedTreatmentType", "RegistrationDate", "ReleaseInfoCertifiedBy", "ReleaseInfoRemarks", "SecondNegativeConfirmationDate", "SeverityUponDiagnosis", "Status", "WardNumber" },
                values: new object[] { "", new DateTime(2024, 1, 31, 13, 11, 46, 511, DateTimeKind.Local).AddTicks(3708), "rgpeiris", new DateTime(2024, 1, 31, 13, 11, 46, 511, DateTimeKind.Local).AddTicks(3719), new DateTime(2024, 1, 31, 13, 11, 46, 511, DateTimeKind.Local).AddTicks(3709), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "(+94) 77 260 7755", 0, "", 0, 1, "(+94) 77 260 1155", "", new DateTime(2024, 1, 31, 13, 11, 46, 511, DateTimeKind.Local).AddTicks(3708), 0, "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "REGISTRATION COMPLETED", "" });

            migrationBuilder.UpdateData(
                table: "PatientMedicalHistories",
                keyColumn: "PatientMedicalHistoryId",
                keyValue: 1,
                column: "ExaminedDate",
                value: new DateTime(2024, 1, 31, 13, 11, 46, 511, DateTimeKind.Local).AddTicks(3736));
        }
    }
}
