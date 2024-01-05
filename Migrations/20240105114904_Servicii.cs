using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Migrations
{
    /// <inheritdoc />
    public partial class Servicii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departament",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeDepartament = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departament", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Medic",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeMedic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartamentID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medic", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Medic_Departament_DepartamentID",
                        column: x => x.DepartamentID,
                        principalTable: "Departament",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeClient = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Client_Medic_MedicID",
                        column: x => x.MedicID,
                        principalTable: "Medic",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Serviciu",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DENUMIRE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DESCRIERE = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PRET = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    DepartamentID = table.Column<int>(type: "int", nullable: false),
                    MedicID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serviciu", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Serviciu_Departament_DepartamentID",
                        column: x => x.DepartamentID,
                        principalTable: "Departament",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Serviciu_Medic_MedicID",
                        column: x => x.MedicID,
                        principalTable: "Medic",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Programare",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataProgramare = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ServiciuID = table.Column<int>(type: "int", nullable: false),
                    ClientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programare", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Programare_Client_ClientID",
                        column: x => x.ClientID,
                        principalTable: "Client",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Programare_Serviciu_ServiciuID",
                        column: x => x.ServiciuID,
                        principalTable: "Serviciu",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_MedicID",
                table: "Client",
                column: "MedicID");

            migrationBuilder.CreateIndex(
                name: "IX_Medic_DepartamentID",
                table: "Medic",
                column: "DepartamentID");

            migrationBuilder.CreateIndex(
                name: "IX_Programare_ClientID",
                table: "Programare",
                column: "ClientID");

            migrationBuilder.CreateIndex(
                name: "IX_Programare_ServiciuID",
                table: "Programare",
                column: "ServiciuID");

            migrationBuilder.CreateIndex(
                name: "IX_Serviciu_DepartamentID",
                table: "Serviciu",
                column: "DepartamentID");

            migrationBuilder.CreateIndex(
                name: "IX_Serviciu_MedicID",
                table: "Serviciu",
                column: "MedicID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programare");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Serviciu");

            migrationBuilder.DropTable(
                name: "Medic");

            migrationBuilder.DropTable(
                name: "Departament");
        }
    }
}
