using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabsManager.Migrations
{
    /// <inheritdoc />
    public partial class FixLabs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_labs_subjects_Subjectid",
                table: "labs");

            migrationBuilder.RenameColumn(
                name: "Subjectid",
                table: "labs",
                newName: "subjectId");

            migrationBuilder.RenameIndex(
                name: "IX_labs_Subjectid",
                table: "labs",
                newName: "IX_labs_subjectId");

            migrationBuilder.AlterColumn<int>(
                name: "subjectId",
                table: "labs",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_labs_subjects_subjectId",
                table: "labs",
                column: "subjectId",
                principalTable: "subjects",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_labs_subjects_subjectId",
                table: "labs");

            migrationBuilder.RenameColumn(
                name: "subjectId",
                table: "labs",
                newName: "Subjectid");

            migrationBuilder.RenameIndex(
                name: "IX_labs_subjectId",
                table: "labs",
                newName: "IX_labs_Subjectid");

            migrationBuilder.AlterColumn<int>(
                name: "Subjectid",
                table: "labs",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_labs_subjects_Subjectid",
                table: "labs",
                column: "Subjectid",
                principalTable: "subjects",
                principalColumn: "id");
        }
    }
}
