using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalaoT2.Data.Migrations
{
    public partial class _20210227_1244 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_Cliente_ClienteId",
                table: "Agendamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_ServicoSolicitado_ServicoSolicitadoId",
                table: "Agendamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Endereco_IdEndereco",
                table: "Funcionario");

            migrationBuilder.RenameColumn(
                name: "IdEndereco",
                table: "Funcionario",
                newName: "EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionario_IdEndereco",
                table: "Funcionario",
                newName: "IX_Funcionario_EnderecoId");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "ServicoSolicitadoID",
                table: "Agendamento",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClienteID",
                table: "Agendamento",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Endereco_EnderecoId",
                table: "Funcionario",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_Cliente_ClienteID",
                table: "Agendamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Agendamento_ServicoSolicitado_ServicoSolicitadoID",
                table: "Agendamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Endereco_EnderecoId",
                table: "Funcionario");

            migrationBuilder.RenameColumn(
                name: "EnderecoId",
                table: "Funcionario",
                newName: "IdEndereco");

            migrationBuilder.RenameIndex(
                name: "IX_Funcionario_EnderecoId",
                table: "Funcionario",
                newName: "IX_Funcionario_IdEndereco");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "ServicoSolicitadoId",
                table: "Agendamento",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClienteId",
                table: "Agendamento",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamento_Cliente_ClienteId",
                table: "Agendamento",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamento_ServicoSolicitado_ServicoSolicitadoId",
                table: "Agendamento",
                column: "ServicoSolicitadoId",
                principalTable: "ServicoSolicitado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Endereco_IdEndereco",
                table: "Funcionario",
                column: "IdEndereco",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
