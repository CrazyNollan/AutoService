using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoService.Data.Migrations
{
    public partial class DefaultDataLoadInClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Down(migrationBuilder);
            migrationBuilder.Sql("INSERT INTO Clients (Email, Name, Surname, Patronymic, AddressId) VALUES ('pasha@mail.ru', 'Pasha', 'Manchukevich', 'Serheivich', '1')");
            migrationBuilder.Sql("INSERT INTO Clients (Email, Name, Surname, Patronymic, AddressId) VALUES ('ivan@mail.ru', 'Ivan', 'Ivanov', 'Ivanovich', '2')");
            migrationBuilder.Sql("INSERT INTO Clients (Email, Name, Surname, Patronymic, AddressId) VALUES ('sasha@mail.ru', 'Sasha', 'Stepanov', 'Alexandrovich', '3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Clients");
        }
    }
}