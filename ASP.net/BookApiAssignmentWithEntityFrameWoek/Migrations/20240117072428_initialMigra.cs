using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookApiAssignmentWithEntityFrameWoek.Migrations
{
    /// <inheritdoc />
    public partial class initialMigra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                       
                    Book = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Author = table.Column<string>(type: "varchar(30)", nullable: false),
                    Language = table.Column<string>(type: "varchar(30)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_books", x => x.BookId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "books");
        }
    }
}
