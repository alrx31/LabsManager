using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabsManager.Migrations
{
    /// <inheritdoc />
    public partial class FixExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "fileExtension",
                table: "PassModels",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fileExtension",
                table: "PassModels");
        }
    }
}
