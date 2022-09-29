using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imtahan_Proqrami.Migrations
{
    public partial class Initiall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    LessonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LessonCode = table.Column<int>(type: "int", nullable: false),
                    LessonName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class = table.Column<int>(type: "int", nullable: false),
                    LessonTeacherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LessonTeacherSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.LessonId);
                });

            migrationBuilder.CreateTable(
                name: "Pupils",
                columns: table => new
                {
                    PupilId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PupilNumber = table.Column<int>(type: "int", nullable: false),
                    Class = table.Column<int>(type: "int", nullable: false),
                    PupilName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PupilSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pupils", x => x.PupilId);
                });

            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    ExamId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    PupilId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.ExamId);
                    table.ForeignKey(
                        name: "FK_Exams_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "LessonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Exams_Pupils_PupilId",
                        column: x => x.PupilId,
                        principalTable: "Pupils",
                        principalColumn: "PupilId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exams_LessonId",
                table: "Exams",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Exams_PupilId",
                table: "Exams",
                column: "PupilId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exams");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Pupils");
        }
    }
}
