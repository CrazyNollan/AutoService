using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoService.Data.Migrations
{
    public partial class DefaultDataLoadInUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Down(migrationBuilder);
            migrationBuilder.Sql("INSERT INTO Users (Name, Surname, TokenNumber, Login, Password) VALUES ('Pasha', 'Manchukevich', '9999999', 'pasha@mail.ru', '1q2q3q4q')");
            migrationBuilder.Sql("INSERT INTO Users (Name, Surname, TokenNumber, Login, Password) VALUES ('Sasha', 'Korshak', '6666666', 'sasha@mail.ru', '1q2q3q4q')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Users");
        }
    }
}