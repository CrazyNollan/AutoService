using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoService.Data.Migrations
{
    public partial class DefaultDataLoadInAddresses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Down(migrationBuilder);
            migrationBuilder.Sql("INSERT INTO Addresses (Country, City, Street, House) VALUES ('Belarus', 'Minsk', 'Pushkinskaya', '20')");
            migrationBuilder.Sql("INSERT INTO Addresses (Country, City, Street, House) VALUES ('Russian', 'Moskow', 'Pushkinskaya', '10')");
            migrationBuilder.Sql("INSERT INTO Addresses (Country, City, Street, House) VALUES ('Belarus', 'Minsk', 'Pushkinskaya', '50')");
            migrationBuilder.Sql("INSERT INTO Addresses (Country, City, Street, House) VALUES ('Belarus', 'Minsk', 'Pushkinskaya', '70')");
            migrationBuilder.Sql("INSERT INTO Addresses (Country, City, Street, House) VALUES ('Russia', 'Kaliningrad', 'Pushkinskaya', '50')");
            migrationBuilder.Sql("INSERT INTO Addresses (Country, City, Street, House) VALUES ('Belarus', 'Brest', 'Yarovaya', '39')");
            migrationBuilder.Sql("INSERT INTO Addresses (Country, City, Street, House) VALUES ('Belarus', 'Vitebsk', 'Pobeditelei', '15')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Addresses");
        }
    }
}