using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PatientManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedPatientTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PandemicPatients",
                columns: new[] { "PatientId", "Address", "Age", "BedNumber", "ConfirmedDate", "CreatedBy", "CreatedDate", "CriticalMedicalInformation", "DSDivision", "DateOfBirth", "DateOfDeath", "DateOfHospitalization", "DateOfRecovery", "District", "FirstNegativeConfirmationDate", "ForeignEntrant", "Gender", "GramaNiladhariArea", "GuardianAddress", "GuardianAssignedUsername", "GuardianNICNumber", "GuardianName", "GuardianPhoneNumber", "GuardianRelationship", "HealthcareProfessionalInCharge", "HospitalAdmissionNo", "HospitalId", "LocalGovernmentInCharge", "MOHArea", "MedicalReportingAgency", "NICNumber", "OtherMedicalNotes", "PassportNumber", "PatientName", "PhoneNumber", "RecommendedTreatmentType", "RegistrationDate", "ReleaseInfoCertifiedBy", "ReleaseInfoRemarks", "ReportedHealthCenter", "SecondNegativeConfirmationDate", "SeverityUponDiagnosis", "Status", "WardNumber" },
                values: new object[] { 1, "Colombo", 32, "", new DateTime(2024, 1, 15, 17, 16, 44, 260, DateTimeKind.Local).AddTicks(2455), "rgpeiris", new DateTime(2024, 1, 15, 17, 16, 44, 260, DateTimeKind.Local).AddTicks(2466), "N/A", "Colombo", new DateTime(2024, 1, 15, 17, 16, 44, 260, DateTimeKind.Local).AddTicks(2456), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colombo", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Male", "GramaNiladhariArea", "Colombo", "gp_gdesilva", "757237777V", "Gamini De Silva", "(+94) 77 260 7755", "Father", 0, "", 0, 1, "Colombo", "Medical Reporting Agency 1", "912837882V", "N/A", "N7464213", "Ashen De Silva", "(+94) 77 260 1155", "", new DateTime(2024, 1, 15, 17, 16, 44, 260, DateTimeKind.Local).AddTicks(2440), 0, "", "Reported Health Center 1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "", "REGISTRATION COMPLETED", "" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PandemicPatients",
                keyColumn: "PatientId",
                keyValue: 1);
        }
    }
}
