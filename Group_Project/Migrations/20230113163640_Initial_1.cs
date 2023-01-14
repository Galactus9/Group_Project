using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroupProject.Migrations
{
    /// <inheritdoc />
    public partial class Initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CandidateExamQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExamQuestionId = table.Column<int>(type: "int", nullable: false),
                    ExamAnswer = table.Column<int>(type: "int", nullable: false),
                    CandidateExamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateExamQuestions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CandidateExamQuestions_CandidateExam_CandidateExamId",
                        column: x => x.CandidateExamId,
                        principalTable: "CandidateExam",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CandidateExamQuestions_ExamQuestions_ExamQuestionId",
                        column: x => x.ExamQuestionId,
                        principalTable: "ExamQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateExamQuestions_CandidateExamId",
                table: "CandidateExamQuestions",
                column: "CandidateExamId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateExamQuestions_ExamQuestionId",
                table: "CandidateExamQuestions",
                column: "ExamQuestionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateExamQuestions");
        }
    }
}
