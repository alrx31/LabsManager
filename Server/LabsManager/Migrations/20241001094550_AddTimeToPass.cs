using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabsManager.Migrations
{
    /// <inheritdoc />
    public partial class AddTimeToPass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastTimeToPass",
                table: "Labs",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastTimeToPass",
                table: "Labs");
        }
    }
}
