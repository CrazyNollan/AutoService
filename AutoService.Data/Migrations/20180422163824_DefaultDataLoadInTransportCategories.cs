using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoService.Data.Migrations
{
    public partial class DefaultDataLoadInTransportCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Down(migrationBuilder);
            migrationBuilder.Sql("INSERT INTO TransportCategories (Name) VALUES ('A')");
            migrationBuilder.Sql("INSERT INTO TransportCategories (Name) VALUES ('B')");
            migrationBuilder.Sql("INSERT INTO TransportCategories (Name) VALUES ('C')");
            migrationBuilder.Sql("INSERT INTO TransportCategories (Name) VALUES ('D')");
            migrationBuilder.Sql("INSERT INTO TransportCategories (Name) VALUES ('BE')");
            migrationBuilder.Sql("INSERT INTO TransportCategories (Name) VALUES ('CE')");
            migrationBuilder.Sql("INSERT INTO TransportCategories (Name) VALUES ('DE')");
            migrationBuilder.Sql("INSERT INTO TransportCategories (Name) VALUES ('Tm')");
            migrationBuilder.Sql("INSERT INTO TransportCategories (Name) VALUES ('Tb')");
            migrationBuilder.Sql("INSERT INTO TransportCategories (Name) VALUES ('M')");
            migrationBuilder.Sql("INSERT INTO TransportCategories (Name) VALUES ('A1')");
            migrationBuilder.Sql("INSERT INTO TransportCategories (Name) VALUES ('B1')");
            migrationBuilder.Sql("INSERT INTO TransportCategories (Name) VALUES ('C1')");
            migrationBuilder.Sql("INSERT INTO TransportCategories (Name) VALUES ('D1')");
            migrationBuilder.Sql("INSERT INTO TransportCategories (Name) VALUES ('C1E')");
            migrationBuilder.Sql("INSERT INTO TransportCategories (Name) VALUES ('D1E')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM TransportCategories WHERE Name = 'A'");
            migrationBuilder.Sql("DELETE FROM TransportCategories WHERE Name = 'B'");
            migrationBuilder.Sql("DELETE FROM TransportCategories WHERE Name = 'C'");
            migrationBuilder.Sql("DELETE FROM TransportCategories WHERE Name = 'D'");
            migrationBuilder.Sql("DELETE FROM TransportCategories WHERE Name = 'BE'");
            migrationBuilder.Sql("DELETE FROM TransportCategories WHERE Name = 'CE'");
            migrationBuilder.Sql("DELETE FROM TransportCategories WHERE Name = 'DE'");
            migrationBuilder.Sql("DELETE FROM TransportCategories WHERE Name = 'Tm'");
            migrationBuilder.Sql("DELETE FROM TransportCategories WHERE Name = 'Tb'");
            migrationBuilder.Sql("DELETE FROM TransportCategories WHERE Name = 'M'");
            migrationBuilder.Sql("DELETE FROM TransportCategories WHERE Name = 'A1'");
            migrationBuilder.Sql("DELETE FROM TransportCategories WHERE Name = 'B1'");
            migrationBuilder.Sql("DELETE FROM TransportCategories WHERE Name = 'C1'");
            migrationBuilder.Sql("DELETE FROM TransportCategories WHERE Name = 'D1'");
            migrationBuilder.Sql("DELETE FROM TransportCategories WHERE Name = 'C1E'");
            migrationBuilder.Sql("DELETE FROM TransportCategories WHERE Name = 'D1E'");
        }
    }
}