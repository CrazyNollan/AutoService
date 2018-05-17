using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoService.Data.Migrations
{
    public partial class DefaultDataLoadInModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Down(migrationBuilder);
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('100')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('150')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('200')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('250')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('300')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('350')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('400')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('450')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('500')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('550')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('600')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('650')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('700')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('750')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('800')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('850')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('900')");
            migrationBuilder.Sql("INSERT INTO TransportModels (Name) VALUES ('950')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '100'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '150'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '200'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '250'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '300'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '350'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '400'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '450'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '500'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '550'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '600'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '650'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '700'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '750'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '800'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '850'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '900'");
            migrationBuilder.Sql("DELETE FROM TransportModels WHERE Name = '950'");
        }
    }
}