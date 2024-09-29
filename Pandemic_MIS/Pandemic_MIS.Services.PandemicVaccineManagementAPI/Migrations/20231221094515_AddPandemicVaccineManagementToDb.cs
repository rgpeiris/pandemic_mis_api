using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicVaccineManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddPandemicVaccineManagementToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PandemicVaccinations",
                columns: table => new
                {
                    PandemicVaccinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NICNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MOHArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GramaNiladhariArea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SerialNumber = table.Column<int>(type: "int", nullable: false),
                    VaccineName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaccineDose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VaccinationCentreId = table.Column<int>(type: "int", nullable: false),
                    DateOfVaccination = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NextAppointmentDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PandemicVaccinations", x => x.PandemicVaccinationId);
                });

            migrationBuilder.CreateTable(
                name: "PandemicVaccines",
                columns: table => new
                {
                    VaccineId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaccineName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dose = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NextDose = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PandemicVaccines", x => x.VaccineId);
                });

            migrationBuilder.CreateTable(
                name: "ScheduledVaccinationCentres",
                columns: table => new
                {
                    ScheduledVaccinationCentreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VaccinationCentreId = table.Column<int>(type: "int", nullable: false),
                    DateScheduled = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeScheduled = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailableCapacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduledVaccinationCentres", x => x.ScheduledVaccinationCentreId);
                });

            migrationBuilder.CreateTable(
                name: "VaccinationCentres",
                columns: table => new
                {
                    VaccinationCentreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CentreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccinationCentres", x => x.VaccinationCentreId);
                });

            migrationBuilder.CreateTable(
                name: "VaccineAppointments",
                columns: table => new
                {
                    VaccineAppointmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NICNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    BirthYear = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsRequiredReports = table.Column<bool>(type: "bit", nullable: false),
                    VaccinationCentreId = table.Column<int>(type: "int", nullable: false),
                    DateScheduled = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeScheduled = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VaccineAppointments", x => x.VaccineAppointmentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PandemicVaccinations");

            migrationBuilder.DropTable(
                name: "PandemicVaccines");

            migrationBuilder.DropTable(
                name: "ScheduledVaccinationCentres");

            migrationBuilder.DropTable(
                name: "VaccinationCentres");

            migrationBuilder.DropTable(
                name: "VaccineAppointments");
        }
    }
}
