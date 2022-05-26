using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Shopping.Migrations
{
    public partial class AvaliacaoFixClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacaos_Clients_ClientCPF",
                table: "Avaliacaos");

            migrationBuilder.AlterColumn<string>(
                name: "ClientCPF",
                table: "Avaliacaos",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacaos_Clients_ClientCPF",
                table: "Avaliacaos",
                column: "ClientCPF",
                principalTable: "Clients",
                principalColumn: "CPF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Avaliacaos_Clients_ClientCPF",
                table: "Avaliacaos");

            migrationBuilder.AlterColumn<string>(
                name: "ClientCPF",
                table: "Avaliacaos",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Avaliacaos_Clients_ClientCPF",
                table: "Avaliacaos",
                column: "ClientCPF",
                principalTable: "Clients",
                principalColumn: "CPF",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
