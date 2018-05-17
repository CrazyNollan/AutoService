using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AutoService.Data.Migrations
{
    public partial class CreateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: false),
                    Country = table.Column<string>(nullable: false),
                    House = table.Column<int>(nullable: false),
                    Street = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fuel",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuel", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportMakes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportMakes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransportModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportModels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Patronymic = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clients_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DriverLicenses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    Day = table.Column<int>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    Number = table.Column<string>(nullable: false),
                    TransportCategoryId = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverLicenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DriverLicenses_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DriverLicenses_TransportCategories_TransportCategoryId",
                        column: x => x.TransportCategoryId,
                        principalTable: "TransportCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transport",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClientId = table.Column<int>(nullable: false),
                    FuelId = table.Column<int>(nullable: false),
                    Number = table.Column<string>(nullable: false),
                    TransportCategoryId = table.Column<int>(nullable: false),
                    TransportMakeId = table.Column<int>(nullable: false),
                    TransportModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transport", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transport_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transport_Fuel_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transport_TransportCategories_TransportCategoryId",
                        column: x => x.TransportCategoryId,
                        principalTable: "TransportCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transport_TransportMakes_TransportMakeId",
                        column: x => x.TransportMakeId,
                        principalTable: "TransportMakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transport_TransportModels_TransportModelId",
                        column: x => x.TransportModelId,
                        principalTable: "TransportModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inspections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExpireYear = table.Column<int>(nullable: false),
                    IsPassed = table.Column<bool>(nullable: false),
                    Number = table.Column<string>(nullable: false),
                    StartYear = table.Column<int>(nullable: false),
                    TransportId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inspections_Transport_TransportId",
                        column: x => x.TransportId,
                        principalTable: "Transport",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AddressId",
                table: "Clients",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_Email",
                table: "Clients",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DriverLicenses_ClientId",
                table: "DriverLicenses",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_DriverLicenses_Number",
                table: "DriverLicenses",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DriverLicenses_TransportCategoryId",
                table: "DriverLicenses",
                column: "TransportCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Fuel_Name",
                table: "Fuel",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_Number",
                table: "Inspections",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_TransportId",
                table: "Inspections",
                column: "TransportId");

            migrationBuilder.CreateIndex(
                name: "IX_Transport_ClientId",
                table: "Transport",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Transport_FuelId",
                table: "Transport",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Transport_Number",
                table: "Transport",
                column: "Number",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transport_TransportCategoryId",
                table: "Transport",
                column: "TransportCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Transport_TransportMakeId",
                table: "Transport",
                column: "TransportMakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Transport_TransportModelId",
                table: "Transport",
                column: "TransportModelId");

            migrationBuilder.CreateIndex(
                name: "IX_TransportCategories_Name",
                table: "TransportCategories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransportMakes_Name",
                table: "TransportMakes",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TransportModels_Name",
                table: "TransportModels",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DriverLicenses");

            migrationBuilder.DropTable(
                name: "Inspections");

            migrationBuilder.DropTable(
                name: "Transport");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Fuel");

            migrationBuilder.DropTable(
                name: "TransportCategories");

            migrationBuilder.DropTable(
                name: "TransportMakes");

            migrationBuilder.DropTable(
                name: "TransportModels");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}