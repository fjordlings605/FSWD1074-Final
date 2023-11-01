using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace burble_api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Burble",
                columns: table => new
                {
                    BurbId = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    TimeDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    BurbTxt = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Burble", x => x.BurbId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    State = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "Burble",
                columns: new[] { "BurbId", "BurbTxt", "TimeDate", "Username" },
                values: new object[,]
                {
                    { "1", "First Burb Ever!  Woot Woot!", new DateTime(2023, 10, 30, 23, 48, 25, 776, DateTimeKind.Local).AddTicks(4080), "Default01" },
                    { "2", "Second Burb, Great as the First!  BlblBlblbrblrblbrbrlbrbbrbll!", new DateTime(2023, 10, 30, 23, 48, 25, 776, DateTimeKind.Local).AddTicks(4129), "Default02" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Burble");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
