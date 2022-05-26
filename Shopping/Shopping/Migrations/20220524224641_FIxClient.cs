using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping.Migrations
{
    public partial class FIxClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clients_ClientId",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_ClientId",
                table: "Compras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Clients");

            migrationBuilder.AddColumn<string>(
                name: "ClientCPF",
                table: "Compras",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Clients",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "CPF");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ClientCPF",
                table: "Compras",
                column: "ClientCPF");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clients_ClientCPF",
                table: "Compras",
                column: "ClientCPF",
                principalTable: "Clients",
                principalColumn: "CPF",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Clients_ClientCPF",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_ClientCPF",
                table: "Compras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "ClientCPF",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Clients");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Compras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Clients",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ClientId",
                table: "Compras",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Clients_ClientId",
                table: "Compras",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
