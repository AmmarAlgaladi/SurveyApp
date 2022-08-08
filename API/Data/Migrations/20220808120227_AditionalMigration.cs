using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class AditionalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Survey_SurveyId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_RespondentIp_Survey_SurveyId",
                table: "RespondentIp");

            migrationBuilder.DropForeignKey(
                name: "FK_Response_Question_QuestionId",
                table: "Response");

            migrationBuilder.DropForeignKey(
                name: "FK_Survey_AspNetUsers_AppUserId",
                table: "Survey");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Survey",
                table: "Survey");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Question",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "Survey",
                newName: "Surveys");

            migrationBuilder.RenameTable(
                name: "Question",
                newName: "Questions");

            migrationBuilder.RenameIndex(
                name: "IX_Survey_AppUserId",
                table: "Surveys",
                newName: "IX_Surveys_AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Question_SurveyId",
                table: "Questions",
                newName: "IX_Questions_SurveyId");

            migrationBuilder.AddColumn<int>(
                name: "AnswerId",
                table: "Response",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "QuestionCount",
                table: "Surveys",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ChoiceCount",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Surveys",
                table: "Surveys",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnswerTxt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionId = table.Column<int>(type: "int", nullable: true),
                    SurveyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Response_AnswerId",
                table: "Response",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Surveys_SurveyId",
                table: "Questions",
                column: "SurveyId",
                principalTable: "Surveys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RespondentIp_Surveys_SurveyId",
                table: "RespondentIp",
                column: "SurveyId",
                principalTable: "Surveys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Response_Answers_AnswerId",
                table: "Response",
                column: "AnswerId",
                principalTable: "Answers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Response_Questions_QuestionId",
                table: "Response",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Surveys_AspNetUsers_AppUserId",
                table: "Surveys",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Surveys_SurveyId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_RespondentIp_Surveys_SurveyId",
                table: "RespondentIp");

            migrationBuilder.DropForeignKey(
                name: "FK_Response_Answers_AnswerId",
                table: "Response");

            migrationBuilder.DropForeignKey(
                name: "FK_Response_Questions_QuestionId",
                table: "Response");

            migrationBuilder.DropForeignKey(
                name: "FK_Surveys_AspNetUsers_AppUserId",
                table: "Surveys");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropIndex(
                name: "IX_Response_AnswerId",
                table: "Response");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Surveys",
                table: "Surveys");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "AnswerId",
                table: "Response");

            migrationBuilder.DropColumn(
                name: "QuestionCount",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "ChoiceCount",
                table: "Questions");

            migrationBuilder.RenameTable(
                name: "Surveys",
                newName: "Survey");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "Question");

            migrationBuilder.RenameIndex(
                name: "IX_Surveys_AppUserId",
                table: "Survey",
                newName: "IX_Survey_AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_SurveyId",
                table: "Question",
                newName: "IX_Question_SurveyId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUserRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Survey",
                table: "Survey",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Question",
                table: "Question",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Survey_SurveyId",
                table: "Question",
                column: "SurveyId",
                principalTable: "Survey",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RespondentIp_Survey_SurveyId",
                table: "RespondentIp",
                column: "SurveyId",
                principalTable: "Survey",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Response_Question_QuestionId",
                table: "Response",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Survey_AspNetUsers_AppUserId",
                table: "Survey",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
