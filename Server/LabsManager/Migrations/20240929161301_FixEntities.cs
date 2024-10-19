using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LabsManager.Migrations
{
    /// <inheritdoc />
    public partial class FixEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Labs_Teachers_TeacherId",
                table: "Labs");

            migrationBuilder.DropForeignKey(
                name: "FK_PassModels_Labs_LabaId",
                table: "PassModels");

            migrationBuilder.DropForeignKey(
                name: "FK_PassModels_Students_StudentId",
                table: "PassModels");

            migrationBuilder.DropForeignKey(
                name: "FK_PassModels_Teachers_TeacherId",
                table: "PassModels");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Teachers",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Teachers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "Teachers",
                newName: "login");

            migrationBuilder.RenameColumn(
                name: "IsAdmin",
                table: "Teachers",
                newName: "isAdmin");

            migrationBuilder.RenameColumn(
                name: "Cafedra",
                table: "Teachers",
                newName: "cafedra");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Teachers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Students",
                newName: "password");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Login",
                table: "Students",
                newName: "login");

            migrationBuilder.RenameColumn(
                name: "Group",
                table: "Students",
                newName: "group");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "PassModels",
                newName: "teacherId");

            migrationBuilder.RenameColumn(
                name: "StudentId",
                table: "PassModels",
                newName: "studentId");

            migrationBuilder.RenameColumn(
                name: "Mark",
                table: "PassModels",
                newName: "mark");

            migrationBuilder.RenameColumn(
                name: "IsPassed",
                table: "PassModels",
                newName: "isPassed");

            migrationBuilder.RenameColumn(
                name: "IsChecked",
                table: "PassModels",
                newName: "isChecked");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "PassModels",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "LabaId",
                table: "PassModels",
                newName: "labId");

            migrationBuilder.RenameIndex(
                name: "IX_PassModels_TeacherId",
                table: "PassModels",
                newName: "IX_PassModels_teacherId");

            migrationBuilder.RenameIndex(
                name: "IX_PassModels_StudentId",
                table: "PassModels",
                newName: "IX_PassModels_studentId");

            migrationBuilder.RenameIndex(
                name: "IX_PassModels_LabaId",
                table: "PassModels",
                newName: "IX_PassModels_labId");

            migrationBuilder.RenameColumn(
                name: "TeacherId",
                table: "Labs",
                newName: "teacherId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Labs",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Materials",
                table: "Labs",
                newName: "materials");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Labs",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Labs",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Labs_TeacherId",
                table: "Labs",
                newName: "IX_Labs_teacherId");

            migrationBuilder.AlterColumn<int>(
                name: "teacherId",
                table: "PassModels",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "mark",
                table: "PassModels",
                type: "real",
                nullable: false,
                defaultValue: 0f,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "comment",
                table: "PassModels",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "report",
                table: "PassModels",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "file",
                table: "Labs",
                type: "bytea",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddForeignKey(
                name: "FK_Labs_Teachers_teacherId",
                table: "Labs",
                column: "teacherId",
                principalTable: "Teachers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PassModels_Labs_labId",
                table: "PassModels",
                column: "labId",
                principalTable: "Labs",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PassModels_Students_studentId",
                table: "PassModels",
                column: "studentId",
                principalTable: "Students",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PassModels_Teachers_teacherId",
                table: "PassModels",
                column: "teacherId",
                principalTable: "Teachers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Labs_Teachers_teacherId",
                table: "Labs");

            migrationBuilder.DropForeignKey(
                name: "FK_PassModels_Labs_labId",
                table: "PassModels");

            migrationBuilder.DropForeignKey(
                name: "FK_PassModels_Students_studentId",
                table: "PassModels");

            migrationBuilder.DropForeignKey(
                name: "FK_PassModels_Teachers_teacherId",
                table: "PassModels");

            migrationBuilder.DropColumn(
                name: "comment",
                table: "PassModels");

            migrationBuilder.DropColumn(
                name: "report",
                table: "PassModels");

            migrationBuilder.DropColumn(
                name: "file",
                table: "Labs");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Teachers",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Teachers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "login",
                table: "Teachers",
                newName: "Login");

            migrationBuilder.RenameColumn(
                name: "isAdmin",
                table: "Teachers",
                newName: "IsAdmin");

            migrationBuilder.RenameColumn(
                name: "cafedra",
                table: "Teachers",
                newName: "Cafedra");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Teachers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Students",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Students",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "login",
                table: "Students",
                newName: "Login");

            migrationBuilder.RenameColumn(
                name: "group",
                table: "Students",
                newName: "Group");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Students",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "teacherId",
                table: "PassModels",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "studentId",
                table: "PassModels",
                newName: "StudentId");

            migrationBuilder.RenameColumn(
                name: "mark",
                table: "PassModels",
                newName: "Mark");

            migrationBuilder.RenameColumn(
                name: "isPassed",
                table: "PassModels",
                newName: "IsPassed");

            migrationBuilder.RenameColumn(
                name: "isChecked",
                table: "PassModels",
                newName: "IsChecked");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "PassModels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "labId",
                table: "PassModels",
                newName: "LabaId");

            migrationBuilder.RenameIndex(
                name: "IX_PassModels_teacherId",
                table: "PassModels",
                newName: "IX_PassModels_TeacherId");

            migrationBuilder.RenameIndex(
                name: "IX_PassModels_studentId",
                table: "PassModels",
                newName: "IX_PassModels_StudentId");

            migrationBuilder.RenameIndex(
                name: "IX_PassModels_labId",
                table: "PassModels",
                newName: "IX_PassModels_LabaId");

            migrationBuilder.RenameColumn(
                name: "teacherId",
                table: "Labs",
                newName: "TeacherId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Labs",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "materials",
                table: "Labs",
                newName: "Materials");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Labs",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Labs",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Labs_teacherId",
                table: "Labs",
                newName: "IX_Labs_TeacherId");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "PassModels",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<float>(
                name: "Mark",
                table: "PassModels",
                type: "real",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddForeignKey(
                name: "FK_Labs_Teachers_TeacherId",
                table: "Labs",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PassModels_Labs_LabaId",
                table: "PassModels",
                column: "LabaId",
                principalTable: "Labs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PassModels_Students_StudentId",
                table: "PassModels",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PassModels_Teachers_TeacherId",
                table: "PassModels",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");
        }
    }
}
