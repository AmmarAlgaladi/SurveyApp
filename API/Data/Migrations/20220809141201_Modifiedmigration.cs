using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    public partial class Modifiedmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Response_Answers_AnswerId",
                table: "Response");

            migrationBuilder.DropForeignKey(
                name: "FK_Response_Questions_QuestionId",
                table: "Response");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Response",
                table: "Response");

            migrationBuilder.DropColumn(
                name: "QuestionCount",
                table: "Surveys");

            migrationBuilder.DropColumn(
                name: "ChoiceCount",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "SurveyId",
                table: "Answers");

            migrationBuilder.RenameTable(
                name: "Response",
                newName: "Responses");

            migrationBuilder.RenameColumn(
                name: "Answer",
                table: "Responses",
                newName: "ResponseText");

            migrationBuilder.RenameIndex(
                name: "IX_Response_QuestionId",
                table: "Responses",
                newName: "IX_Responses_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Response_AnswerId",
                table: "Responses",
                newName: "IX_Responses_AnswerId");

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Responses",
                table: "Responses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Answers_AnswerId",
                table: "Responses",
                column: "AnswerId",
                principalTable: "Answers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Questions_QuestionId",
                table: "Responses",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers");

            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Answers_AnswerId",
                table: "Responses");

            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Questions_QuestionId",
                table: "Responses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Responses",
                table: "Responses");

            migrationBuilder.RenameTable(
                name: "Responses",
                newName: "Response");

            migrationBuilder.RenameColumn(
                name: "ResponseText",
                table: "Response",
                newName: "Answer");

            migrationBuilder.RenameIndex(
                name: "IX_Responses_QuestionId",
                table: "Response",
                newName: "IX_Response_QuestionId");

            migrationBuilder.RenameIndex(
                name: "IX_Responses_AnswerId",
                table: "Response",
                newName: "IX_Response_AnswerId");

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

            migrationBuilder.AlterColumn<int>(
                name: "QuestionId",
                table: "Answers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SurveyId",
                table: "Answers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Response",
                table: "Response",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Answers_Questions_QuestionId",
                table: "Answers",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id");

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
        }
    }
}
