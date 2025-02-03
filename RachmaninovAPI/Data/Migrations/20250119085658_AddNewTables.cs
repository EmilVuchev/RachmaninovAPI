using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RachmaninovAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTables : Migration
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
                name: "LetterId",
                table: "Paragraphs",
                type: "int",
                nullable: true);

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
                name: "Letters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    To = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WrittenOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WrittenIn = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Letters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Memoirs",
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
                    table.PrimaryKey("PK_Memoirs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MusicalCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MusicalCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Compositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OpusNumber = table.Column<int>(type: "int", nullable: true),
                    WrittenOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MusicalCategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Compositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Compositions_MusicalCategories_MusicalCategoryId",
                        column: x => x.MusicalCategoryId,
                        principalTable: "MusicalCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recordings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RecordedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompositionId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recordings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recordings_Compositions_CompositionId",
                        column: x => x.CompositionId,
                        principalTable: "Compositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Edition = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompositionId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scores_Compositions_CompositionId",
                        column: x => x.CompositionId,
                        principalTable: "Compositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paragraphs_LetterId",
                table: "Paragraphs",
                column: "LetterId");

            migrationBuilder.CreateIndex(
                name: "IX_Paragraphs_MemoirId",
                table: "Paragraphs",
                column: "MemoirId");

            migrationBuilder.CreateIndex(
                name: "IX_Compositions_MusicalCategoryId",
                table: "Compositions",
                column: "MusicalCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Recordings_CompositionId",
                table: "Recordings",
                column: "CompositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Scores_CompositionId",
                table: "Scores",
                column: "CompositionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paragraphs_Articles_ArticleId",
                table: "Paragraphs",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paragraphs_Letters_LetterId",
                table: "Paragraphs",
                column: "LetterId",
                principalTable: "Letters",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Paragraphs_Memoirs_MemoirId",
                table: "Paragraphs",
                column: "MemoirId",
                principalTable: "Memoirs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paragraphs_Articles_ArticleId",
                table: "Paragraphs");

            migrationBuilder.DropForeignKey(
                name: "FK_Paragraphs_Letters_LetterId",
                table: "Paragraphs");

            migrationBuilder.DropForeignKey(
                name: "FK_Paragraphs_Memoirs_MemoirId",
                table: "Paragraphs");

            migrationBuilder.DropTable(
                name: "Letters");

            migrationBuilder.DropTable(
                name: "Memoirs");

            migrationBuilder.DropTable(
                name: "Recordings");

            migrationBuilder.DropTable(
                name: "Scores");

            migrationBuilder.DropTable(
                name: "Compositions");

            migrationBuilder.DropTable(
                name: "MusicalCategories");

            migrationBuilder.DropIndex(
                name: "IX_Paragraphs_LetterId",
                table: "Paragraphs");

            migrationBuilder.DropIndex(
                name: "IX_Paragraphs_MemoirId",
                table: "Paragraphs");

            migrationBuilder.DropColumn(
                name: "IsPoem",
                table: "Paragraphs");

            migrationBuilder.DropColumn(
                name: "LetterId",
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
