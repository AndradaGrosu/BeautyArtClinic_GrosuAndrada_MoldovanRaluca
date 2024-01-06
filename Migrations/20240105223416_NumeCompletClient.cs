using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeautyArtClinic_GrosuAndrada_MoldovanRaluca.Migrations
{
    /// <inheritdoc />
    public partial class NumeCompletClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Medic_MedicID",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Programare_Client_ClientID",
                table: "Programare");

            migrationBuilder.DropForeignKey(
                name: "FK_Programare_Serviciu_ServiciuID",
                table: "Programare");

            migrationBuilder.DropIndex(
                name: "IX_Client_MedicID",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "MedicID",
                table: "Client");

            migrationBuilder.AlterColumn<int>(
                name: "ServiciuID",
                table: "Programare",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ClientID",
                table: "Programare",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "PrenumeClient",
                table: "Client",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_Client_ClientID",
                table: "Programare",
                column: "ClientID",
                principalTable: "Client",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_Serviciu_ServiciuID",
                table: "Programare",
                column: "ServiciuID",
                principalTable: "Serviciu",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programare_Client_ClientID",
                table: "Programare");

            migrationBuilder.DropForeignKey(
                name: "FK_Programare_Serviciu_ServiciuID",
                table: "Programare");

            migrationBuilder.DropColumn(
                name: "PrenumeClient",
                table: "Client");

            migrationBuilder.AlterColumn<int>(
                name: "ServiciuID",
                table: "Programare",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientID",
                table: "Programare",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MedicID",
                table: "Client",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Client_MedicID",
                table: "Client",
                column: "MedicID");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Medic_MedicID",
                table: "Client",
                column: "MedicID",
                principalTable: "Medic",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_Client_ClientID",
                table: "Programare",
                column: "ClientID",
                principalTable: "Client",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_Serviciu_ServiciuID",
                table: "Programare",
                column: "ServiciuID",
                principalTable: "Serviciu",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
