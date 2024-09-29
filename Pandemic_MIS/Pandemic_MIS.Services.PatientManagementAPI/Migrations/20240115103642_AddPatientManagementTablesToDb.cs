using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PatientManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddPatientManagementTablesToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HealthcareProfessionals",
                columns: table => new
                {
                    HealthcareProfessionalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthcareProfessionalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalSpecialty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedHospital = table.Column<int>(type: "int", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthcareProfessionals", x => x.HealthcareProfessionalId);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    HospitalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.HospitalId);
                });

            migrationBuilder.CreateTable(
                name: "LocalGovernmentInCharge",
                columns: table => new
                {
                    LocalGovernmentInChargeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalGovernmentInChargeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedDistrict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssignedUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalGovernmentInCharge", x => x.LocalGovernmentInChargeId);
                });

            migrationBuilder.CreateTable(
                name: "PandemicPatients",
                columns: table => new
                {
                    PatientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConfirmedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NICNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassportNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PatientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DSDivision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MOHArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GramaNiladhariArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ForeignEntrant = table.Column<bool>(type: "bit", nullable: false),
                    CriticalMedicalInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OtherMedicalNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicalReportingAgency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportedHealthCenter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuardianName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuardianNICNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuardianAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuardianPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuardianAssignedUsername = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuardianRelationship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalGovernmentInCharge = table.Column<int>(type: "int", nullable: false),
                    SeverityUponDiagnosis = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecommendedTreatmentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalId = table.Column<int>(type: "int", nullable: false),
                    WardNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BedNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalAdmissionNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfHospitalization = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HealthcareProfessionalInCharge = table.Column<int>(type: "int", nullable: false),
                    FirstNegativeConfirmationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SecondNegativeConfirmationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfRecovery = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateOfDeath = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReleaseInfoCertifiedBy = table.Column<int>(type: "int", nullable: false),
                    ReleaseInfoRemarks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PandemicPatients", x => x.PatientId);
                });

            migrationBuilder.CreateTable(
                name: "PatientMedicalHistories",
                columns: table => new
                {
                    PatientMedicalHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(type: "int", nullable: false),
                    ExaminedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExaminedBy = table.Column<int>(type: "int", nullable: false),
                    DiagnosisSummary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Treatments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMedicalHistories", x => x.PatientMedicalHistoryId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HealthcareProfessionals");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.DropTable(
                name: "LocalGovernmentInCharge");

            migrationBuilder.DropTable(
                name: "PandemicPatients");

            migrationBuilder.DropTable(
                name: "PatientMedicalHistories");
        }
    }
}
