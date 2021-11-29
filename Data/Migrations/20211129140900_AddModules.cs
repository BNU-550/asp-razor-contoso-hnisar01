using Microsoft.EntityFrameworkCore.Migrations;

namespace asp_razor_contoso.Data.Migrations
{
    public partial class AddModules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ModuleID",
                table: "Courses",
                type: "nvarchar(6)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModuleID = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Credit = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_ModuleID",
                table: "Courses",
                column: "ModuleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Modules_ModuleID",
                table: "Courses",
                column: "ModuleID",
                principalTable: "Modules",
                principalColumn: "ModuleID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Modules_ModuleID",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropIndex(
                name: "IX_Courses_ModuleID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "ModuleID",
                table: "Courses");
        }
    }
}
