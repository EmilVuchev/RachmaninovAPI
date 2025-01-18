using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RachmaninovAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddCompositionLetterMemoirMusicalCategoryRecordingAndScore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paragraphs_Articles_ArticleId",
                table: "Paragraphs");

            migrationBuilder.AlterColumn<int>(
                name: "ArticleId",
                table: "Paragraphs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsPoem",
                table: "Paragraphs",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "MemoirId",
                table: "Paragraphs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Paragraphs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Memoir",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Author = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WrittenOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WrittenIn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Memoir", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paragraphs_MemoirId",
                table: "Paragraphs",
                column: "MemoirId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paragraphs_Articles_ArticleId",
                table: "Paragraphs",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paragraphs_Memoir_MemoirId",
                table: "Paragraphs",
                column: "MemoirId",
                principalTable: "Memoir",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paragraphs_Articles_ArticleId",
                table: "Paragraphs");

            migrationBuilder.DropForeignKey(
                name: "FK_Paragraphs_Memoir_MemoirId",
                table: "Paragraphs");

            migrationBuilder.DropTable(
                name: "Memoir");

            migrationBuilder.DropIndex(
                name: "IX_Paragraphs_MemoirId",
                table: "Paragraphs");

            migrationBuilder.DropColumn(
                name: "IsPoem",
                table: "Paragraphs");

            migrationBuilder.DropColumn(
                name: "MemoirId",
                table: "Paragraphs");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Paragraphs");

            migrationBuilder.AlterColumn<int>(
                name: "ArticleId",
                table: "Paragraphs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Paragraphs_Articles_ArticleId",
                table: "Paragraphs",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
