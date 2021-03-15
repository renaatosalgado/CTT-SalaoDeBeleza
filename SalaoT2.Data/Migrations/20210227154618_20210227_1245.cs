using Microsoft.EntityFrameworkCore.Migrations;

namespace SalaoT2.Data.Migrations
{
    public partial class _20210227_1245 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_Cliente_ClienteID",
                table: "Agendamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_ServicoSolicitado_ServicoSolicitadoID",
                table: "Agendamento");

            migrationBuilder.RenameColumn(
                name: "ServicoSolicitadoID",
                table: "Agendamento",
                newName: "ServicoSolicitadoId");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Agendamento",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Agendamento_ServicoSolicitadoID",
                table: "Agendamento",
                newName: "IX_Agendamento_ServicoSolicitadoId");

            migrationBuilder.RenameIndex(
                name: "IX_Agendamento_ClienteID",
                table: "Agendamento",
                newName: "IX_Agendamento_ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamento_Cliente_ClienteId",
                table: "Agendamento",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamento_ServicoSolicitado_ServicoSolicitadoId",
                table: "Agendamento",
                column: "ServicoSolicitadoId",
                principalTable: "ServicoSolicitado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_Cliente_ClienteId",
                table: "Agendamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_ServicoSolicitado_ServicoSolicitadoId",
                table: "Agendamento");

            migrationBuilder.RenameColumn(
                name: "ServicoSolicitadoId",
                table: "Agendamento",
                newName: "ServicoSolicitadoID");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Agendamento",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Agendamento_ServicoSolicitadoId",
                table: "Agendamento",
                newName: "IX_Agendamento_ServicoSolicitadoID");

            migrationBuilder.RenameIndex(
                name: "IX_Agendamento_ClienteId",
                table: "Agendamento",
                newName: "IX_Agendamento_ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamento_Cliente_ClienteID",
                table: "Agendamento",
                column: "ClienteID",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamento_ServicoSolicitado_ServicoSolicitadoID",
                table: "Agendamento",
                column: "ServicoSolicitadoID",
                principalTable: "ServicoSolicitado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
