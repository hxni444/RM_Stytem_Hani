using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HandsOnEF.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StaffTble",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffTble", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SudentTble",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Class = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Section = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SudentTble", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MarksTble",
                columns: table => new
                {
                    MarksId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Exam = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    TotalMarks = table.Column<int>(type: "int", nullable: true),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarksTble", x => x.MarksId);
                    table.ForeignKey(
                        name: "FK_MarksTble_SudentTble_Id",
                        column: x => x.Id,
                        principalTable: "SudentTble",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MarksTble_Id",
                table: "MarksTble",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarksTble");

            migrationBuilder.DropTable(
                name: "StaffTble");

            migrationBuilder.DropTable(
                name: "SudentTble");
        }
    }
}
