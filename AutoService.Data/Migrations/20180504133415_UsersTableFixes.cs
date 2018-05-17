using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoService.Data.Migrations
{
    public partial class UsersTableFixes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Login",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Login_TokenNumber",
                table: "Users",
                columns: new[] { "Login", "TokenNumber" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Users_Login_TokenNumber",
                table: "Users");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Login",
                table: "Users",
                column: "Login",
                unique: true);
        }
    }
}