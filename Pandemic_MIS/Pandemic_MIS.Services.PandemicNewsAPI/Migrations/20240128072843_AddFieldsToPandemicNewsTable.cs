using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pandemic_MIS.Services.PandemicNewsAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsToPandemicNewsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "PandemicNews",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "PandemicNews",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "PandemicNews",
                keyColumn: "NewsId",
                keyValue: 1,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { "ad_rpeiris", new DateTime(2024, 1, 28, 12, 58, 42, 799, DateTimeKind.Local).AddTicks(7262) });

            migrationBuilder.UpdateData(
                table: "PandemicNews",
                keyColumn: "NewsId",
                keyValue: 2,
                columns: new[] { "CreatedBy", "CreatedDate" },
                values: new object[] { "ad_rpeiris", new DateTime(2024, 1, 28, 12, 58, 42, 799, DateTimeKind.Local).AddTicks(7312) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "PandemicNews");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "PandemicNews");
        }
    }
}
