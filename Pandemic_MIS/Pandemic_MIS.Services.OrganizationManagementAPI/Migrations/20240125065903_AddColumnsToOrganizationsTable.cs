using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.OrganizationManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnsToOrganizationsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Organizations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Organizations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { "ad_rpeiris", new DateTime(2024, 1, 25, 12, 29, 2, 793, DateTimeKind.Local).AddTicks(7499) });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "OrganizationId",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { "ad_rpeiris", new DateTime(2024, 1, 25, 12, 29, 2, 793, DateTimeKind.Local).AddTicks(7537) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Organizations");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Organizations");
        }
    }
}
