using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PatientManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedHealthcareProfessionalsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HealthcareProfessionals",
                columns: new[] { "HealthcareProfessionalId", "AssignedHospital", "AssignedUsername", "HealthcareProfessionalName", "IsActive", "MedicalSpecialty", "PhoneNumber" },
                values: new object[] { 1, 1, "hp_aweerasinghe", "Prof. Anura Weerasinghe", true, "Physician", "(+94) 11 541 0000" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HealthcareProfessionals",
                keyColumn: "HealthcareProfessionalId",
                keyValue: 1);
        }
    }
}
