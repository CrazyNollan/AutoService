using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoService.Data.Migrations
{
    public partial class DefaultDataLoad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Down(migrationBuilder);
            migrationBuilder.Sql("INSERT INTO TransportMakes (Name) VALUES ('BMW')");
            migrationBuilder.Sql("INSERT INTO TransportMakes (Name) VALUES ('Audi')");
            migrationBuilder.Sql("INSERT INTO TransportMakes (Name) VALUES ('Ford')");
            migrationBuilder.Sql("INSERT INTO TransportMakes (Name) VALUES ('Hyundai')");
            migrationBuilder.Sql("INSERT INTO TransportMakes (Name) VALUES ('Kia')");
            migrationBuilder.Sql("INSERT INTO TransportMakes (Name) VALUES ('Lada')");
            migrationBuilder.Sql("INSERT INTO TransportMakes (Name) VALUES ('Nissan')");
            migrationBuilder.Sql("INSERT INTO TransportMakes (Name) VALUES ('Mitsubishi')");
            migrationBuilder.Sql("INSERT INTO TransportMakes (Name) VALUES ('Mercedes-Benz')");
            migrationBuilder.Sql("INSERT INTO TransportMakes (Name) VALUES ('Skoda')");
            migrationBuilder.Sql("INSERT INTO TransportMakes (Name) VALUES ('Toyota')");
            migrationBuilder.Sql("INSERT INTO TransportMakes (Name) VALUES ('Volkswagen')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM TransportMakes WHERE Name = 'BMW'");
            migrationBuilder.Sql("DELETE FROM TransportMakes WHERE Name = 'Audi'");
            migrationBuilder.Sql("DELETE FROM TransportMakes WHERE Name = 'Ford'");
            migrationBuilder.Sql("DELETE FROM TransportMakes WHERE Name = 'Hyundai'");
            migrationBuilder.Sql("DELETE FROM TransportMakes WHERE Name = 'Kia'");
            migrationBuilder.Sql("DELETE FROM TransportMakes WHERE Name = 'Lada'");
            migrationBuilder.Sql("DELETE FROM TransportMakes WHERE Name = 'Nissan'");
            migrationBuilder.Sql("DELETE FROM TransportMakes WHERE Name = 'Mitsubishi'");
            migrationBuilder.Sql("DELETE FROM TransportMakes WHERE Name = 'Mercedes-Benz'");
            migrationBuilder.Sql("DELETE FROM TransportMakes WHERE Name = 'Skoda'");
            migrationBuilder.Sql("DELETE FROM TransportMakes WHERE Name = 'Toyota'");
            migrationBuilder.Sql("DELETE FROM TransportMakes WHERE Name = 'Volkswagen'");
        }
    }
}