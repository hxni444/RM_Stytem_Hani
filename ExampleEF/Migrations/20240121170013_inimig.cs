using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExampleEF.Migrations
{
    /// <inheritdoc />
    public partial class inimig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "colleges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                     
                    CollegeName = table.Column<string>(name: "College Name", type: "nvarchar(50)", maxLength: 50, nullable: false),
                    adminisId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_colleges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    adminisId = table.Column<int>(type: "int", nullable: false),
                      
                    cllgId = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.adminisId);
                    table.ForeignKey(
                        name: "FK_admins_colleges_cllgId",
                        column: x => x.cllgId,
                        principalTable: "colleges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_admins_cllgId",
                table: "admins",
                column: "cllgId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");

            migrationBuilder.DropTable(
                name: "colleges");
        }
    }
}
