using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PatientManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedHospitalAndLocalGovernmentInChargeTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hospitals",
                columns: new[] { "HospitalId", "Address", "City", "District", "HospitalName", "IsActive", "PhoneNumber" },
                values: new object[] { 1, "WV99+FHX, Colombo 00700", "Colombo", "Colombo", "National Hospital of SriLanka", true, "(+94) 11 269 1111" });

            migrationBuilder.InsertData(
                table: "LocalGovernmentInCharge",
                columns: new[] { "LocalGovernmentInChargeId", "AssignedDistrict", "AssignedUsername", "Designation", "IsActive", "LocalGovernmentInChargeName", "PhoneNumber" },
                values: new object[] { 1, "Colombo", "gic_tgamage", "Physician", true, "Prof. Thisara Gamage", "(+94) 11 269 1155" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hospitals",
                keyColumn: "HospitalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "LocalGovernmentInCharge",
                keyColumn: "LocalGovernmentInChargeId",
                keyValue: 1);
        }
    }
}
