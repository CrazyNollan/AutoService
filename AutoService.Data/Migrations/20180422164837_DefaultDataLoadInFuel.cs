using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoService.Data.Migrations
{
    public partial class DefaultDataLoadInFuel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Down(migrationBuilder);
            migrationBuilder.Sql("INSERT INTO Fuel (Name) VALUES ('Petrol')");
            migrationBuilder.Sql("INSERT INTO Fuel (Name) VALUES ('Diesel')");
            migrationBuilder.Sql("INSERT INTO Fuel (Name) VALUES ('Gas')");
            migrationBuilder.Sql("INSERT INTO Fuel (Name) VALUES ('Hybrid (gasoline)')");
            migrationBuilder.Sql("INSERT INTO Fuel (Name) VALUES ('Petrol (diesel)')");
            migrationBuilder.Sql("INSERT INTO Fuel (Name) VALUES ('Electro')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Fuel WHERE Name = 'Petrol'");
            migrationBuilder.Sql("DELETE FROM Fuel WHERE Name = 'Diesel'");
            migrationBuilder.Sql("DELETE FROM Fuel WHERE Name = 'Gas'");
            migrationBuilder.Sql("DELETE FROM Fuel WHERE Name = 'Hybrid (gasoline)'");
            migrationBuilder.Sql("DELETE FROM Fuel WHERE Name = 'Petrol (diesel)'");
            migrationBuilder.Sql("DELETE FROM Fuel WHERE Name = 'Electro'");
        }
    }
}