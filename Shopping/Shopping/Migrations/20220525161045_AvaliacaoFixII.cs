using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping.Migrations
{
    public partial class AvaliacaoFixII : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacaos_Compras_CompraId",
                table: "Avaliacaos");

            migrationBuilder.RenameColumn(
                name: "CompraId",
                table: "Avaliacaos",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Avaliacaos_CompraId",
                table: "Avaliacaos",
                newName: "IX_Avaliacaos_ProductId");

            migrationBuilder.AddColumn<string>(
                name: "ClientCPF",
                table: "Avaliacaos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CorreioId",
                table: "Avaliacaos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacaos_ClientCPF",
                table: "Avaliacaos",
                column: "ClientCPF");

            migrationBuilder.CreateIndex(
                name: "IX_Avaliacaos_CorreioId",
                table: "Avaliacaos",
                column: "CorreioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacaos_Clients_ClientCPF",
                table: "Avaliacaos",
                column: "ClientCPF",
                principalTable: "Clients",
                principalColumn: "CPF",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacaos_Correios_CorreioId",
                table: "Avaliacaos",
                column: "CorreioId",
                principalTable: "Correios",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacaos_Products_ProductId",
                table: "Avaliacaos",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacaos_Clients_ClientCPF",
                table: "Avaliacaos");

            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacaos_Correios_CorreioId",
                table: "Avaliacaos");

            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacaos_Products_ProductId",
                table: "Avaliacaos");

            migrationBuilder.DropIndex(
                name: "IX_Avaliacaos_ClientCPF",
                table: "Avaliacaos");

            migrationBuilder.DropIndex(
                name: "IX_Avaliacaos_CorreioId",
                table: "Avaliacaos");

            migrationBuilder.DropColumn(
                name: "ClientCPF",
                table: "Avaliacaos");

            migrationBuilder.DropColumn(
                name: "CorreioId",
                table: "Avaliacaos");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Avaliacaos",
                newName: "CompraId");

            migrationBuilder.RenameIndex(
                name: "IX_Avaliacaos_ProductId",
                table: "Avaliacaos",
                newName: "IX_Avaliacaos_CompraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacaos_Compras_CompraId",
                table: "Avaliacaos",
                column: "CompraId",
                principalTable: "Compras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
