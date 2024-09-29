using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.OrganizationManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataToPandemicContactsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 25, 13, 10, 45, 602, DateTimeKind.Local).AddTicks(6701));

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 25, 13, 10, 45, 602, DateTimeKind.Local).AddTicks(6823));

            migrationBuilder.InsertData(
                table: "PandemicContacts",
                columns: new[] { "PandemicContactId", "CheckInTime", "CheckOutTime", "CreatedDate", "Name", "NicNumber", "OrganizationId", "PhoneNumber" },
                values: new object[] { 1, new DateTime(2024, 1, 25, 13, 10, 45, 602, DateTimeKind.Local).AddTicks(6849), new DateTime(2024, 1, 25, 13, 10, 45, 602, DateTimeKind.Local).AddTicks(6849), new DateTime(2024, 1, 25, 13, 10, 45, 602, DateTimeKind.Local).AddTicks(6851), "Nisha Perera", "934455522V", 1, 778364772 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PandemicContacts",
                keyColumn: "PandemicContactId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 25, 13, 2, 38, 708, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 25, 13, 2, 38, 708, DateTimeKind.Local).AddTicks(2355));
        }
    }
}
