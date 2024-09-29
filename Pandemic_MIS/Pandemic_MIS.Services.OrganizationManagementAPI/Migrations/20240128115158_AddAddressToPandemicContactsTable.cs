using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.OrganizationManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddAddressToPandemicContactsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "PandemicContacts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 28, 17, 21, 57, 861, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 28, 17, 21, 57, 861, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "PandemicContacts",
                keyColumn: "PandemicContactId",
                keyValue: 1,
                columns: new[] { "Address", "CheckInTime", "CheckOutTime", "CreatedDate" },
                values: new object[] { "Colombo", new DateTime(2024, 1, 28, 17, 21, 57, 861, DateTimeKind.Local).AddTicks(1106), new DateTime(2024, 1, 28, 17, 21, 57, 861, DateTimeKind.Local).AddTicks(1107), new DateTime(2024, 1, 28, 17, 21, 57, 861, DateTimeKind.Local).AddTicks(1108) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "PandemicContacts");

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 28, 17, 17, 39, 884, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 28, 17, 17, 39, 884, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "PandemicContacts",
                keyColumn: "PandemicContactId",
                keyValue: 1,
                columns: new[] { "CheckInTime", "CheckOutTime", "CreatedDate" },
                values: new object[] { new DateTime(2024, 1, 28, 17, 17, 39, 884, DateTimeKind.Local).AddTicks(3032), new DateTime(2024, 1, 28, 17, 17, 39, 884, DateTimeKind.Local).AddTicks(3033), new DateTime(2024, 1, 28, 17, 17, 39, 884, DateTimeKind.Local).AddTicks(3034) });
        }
    }
}
