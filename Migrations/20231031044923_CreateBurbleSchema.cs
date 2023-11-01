using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace burble_api.Migrations
{
    /// <inheritdoc />
    public partial class CreateBurbleSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Burble",
                keyColumn: "BurbId",
                keyValue: "1",
                column: "TimeDate",
                value: new DateTime(2023, 10, 30, 23, 49, 23, 869, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "Burble",
                keyColumn: "BurbId",
                keyValue: "2",
                column: "TimeDate",
                value: new DateTime(2023, 10, 30, 23, 49, 23, 869, DateTimeKind.Local).AddTicks(4142));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Burble",
                keyColumn: "BurbId",
                keyValue: "1",
                column: "TimeDate",
                value: new DateTime(2023, 10, 30, 23, 48, 25, 776, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "Burble",
                keyColumn: "BurbId",
                keyValue: "2",
                column: "TimeDate",
                value: new DateTime(2023, 10, 30, 23, 48, 25, 776, DateTimeKind.Local).AddTicks(4129));
        }
    }
}
