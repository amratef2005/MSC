using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core.Migrations
{
    /// <inheritdoc />
    public partial class o1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Students_StudentsId",
                table: "CourseStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Teachars");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachars",
                table: "Teachars",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Teachars_StudentsId",
                table: "CourseStudent",
                column: "StudentsId",
                principalTable: "Teachars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseStudent_Teachars_StudentsId",
                table: "CourseStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachars",
                table: "Teachars");

            migrationBuilder.RenameTable(
                name: "Teachars",
                newName: "Students");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseStudent_Students_StudentsId",
                table: "CourseStudent",
                column: "StudentsId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
