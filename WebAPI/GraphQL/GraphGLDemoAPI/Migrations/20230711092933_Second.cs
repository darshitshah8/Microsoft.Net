using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GraphGLDemoAPI.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Courses_CourseDtoId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_CourseDtoId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CourseDtoId",
                table: "Students");

            migrationBuilder.CreateTable(
                name: "CourseDtoStudentDto",
                columns: table => new
                {
                    CoursesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseDtoStudentDto", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CourseDtoStudentDto_Courses_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseDtoStudentDto_Students_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseDtoStudentDto_StudentsId",
                table: "CourseDtoStudentDto",
                column: "StudentsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseDtoStudentDto");

            migrationBuilder.AddColumn<Guid>(
                name: "CourseDtoId",
                table: "Students",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_CourseDtoId",
                table: "Students",
                column: "CourseDtoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Courses_CourseDtoId",
                table: "Students",
                column: "CourseDtoId",
                principalTable: "Courses",
                principalColumn: "Id");
        }
    }
}
