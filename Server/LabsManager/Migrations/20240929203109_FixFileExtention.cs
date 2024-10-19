﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabsManager.Migrations
{
    /// <inheritdoc />
    public partial class FixFileExtention : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FileName",
                table: "Labs",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FileName",
                table: "Labs");
        }
    }
}
