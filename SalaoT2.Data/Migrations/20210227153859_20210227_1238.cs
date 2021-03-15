using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalaoT2.Data.Migrations
{
    public partial class _20210227_1238 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FuncionarioServico_Funcionario_IdFuncionario",
                table: "FuncionarioServico");

            migrationBuilder.DropForeignKey(
                name: "FK_FuncionarioServico_Servico_IdServico",
                table: "FuncionarioServico");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicoSolicitado_Funcionario_IdFuncionario",
                table: "ServicoSolicitado");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicoSolicitado_Servico_IdServico",
                table: "ServicoSolicitado");

            migrationBuilder.DropIndex(
                name: "IX_ServicoSolicitado_IdFuncionario",
                table: "ServicoSolicitado");

            migrationBuilder.DropIndex(
                name: "IX_ServicoSolicitado_IdServico",
                table: "ServicoSolicitado");

            migrationBuilder.RenameColumn(
                name: "IdServico",
                table: "FuncionarioServico",
                newName: "ServicoId");

            migrationBuilder.RenameColumn(
                name: "IdFuncionario",
                table: "FuncionarioServico",
                newName: "FuncionarioId");

            migrationBuilder.RenameIndex(
                name: "IX_FuncionarioServico_IdServico",
                table: "FuncionarioServico",
                newName: "IX_FuncionarioServico_ServicoId");

            migrationBuilder.AddColumn<Guid>(
                name: "FuncionarioId",
                table: "ServicoSolicitado",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ServicoId",
                table: "ServicoSolicitado",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ServicoSolicitado_FuncionarioId",
                table: "ServicoSolicitado",
                column: "FuncionarioId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicoSolicitado_ServicoId",
                table: "ServicoSolicitado",
                column: "ServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_FuncionarioServico_Funcionario_FuncionarioId",
                table: "FuncionarioServico",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FuncionarioServico_Servico_ServicoId",
                table: "FuncionarioServico",
                column: "ServicoId",
                principalTable: "Servico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServicoSolicitado_Funcionario_FuncionarioId",
                table: "ServicoSolicitado",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ServicoSolicitado_Servico_ServicoId",
                table: "ServicoSolicitado",
                column: "ServicoId",
                principalTable: "Servico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FuncionarioServico_Funcionario_FuncionarioId",
                table: "FuncionarioServico");

            migrationBuilder.DropForeignKey(
                name: "FK_FuncionarioServico_Servico_ServicoId",
                table: "FuncionarioServico");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicoSolicitado_Funcionario_FuncionarioId",
                table: "ServicoSolicitado");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicoSolicitado_Servico_ServicoId",
                table: "ServicoSolicitado");

            migrationBuilder.DropIndex(
                name: "IX_ServicoSolicitado_FuncionarioId",
                table: "ServicoSolicitado");

            migrationBuilder.DropIndex(
                name: "IX_ServicoSolicitado_ServicoId",
                table: "ServicoSolicitado");

            migrationBuilder.DropColumn(
                name: "FuncionarioId",
                table: "ServicoSolicitado");

            migrationBuilder.DropColumn(
                name: "ServicoId",
                table: "ServicoSolicitado");

            migrationBuilder.RenameColumn(
                name: "ServicoId",
                table: "FuncionarioServico",
                newName: "IdServico");

            migrationBuilder.RenameColumn(
                name: "FuncionarioId",
                table: "FuncionarioServico",
                newName: "IdFuncionario");

            migrationBuilder.RenameIndex(
                name: "IX_FuncionarioServico_ServicoId",
                table: "FuncionarioServico",
                newName: "IX_FuncionarioServico_IdServico");

            migrationBuilder.CreateIndex(
                name: "IX_ServicoSolicitado_IdFuncionario",
                table: "ServicoSolicitado",
                column: "IdFuncionario");

            migrationBuilder.CreateIndex(
                name: "IX_ServicoSolicitado_IdServico",
                table: "ServicoSolicitado",
                column: "IdServico");

            migrationBuilder.AddForeignKey(
                name: "FK_FuncionarioServico_Funcionario_IdFuncionario",
                table: "FuncionarioServico",
                column: "IdFuncionario",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FuncionarioServico_Servico_IdServico",
                table: "FuncionarioServico",
                column: "IdServico",
                principalTable: "Servico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServicoSolicitado_Funcionario_IdFuncionario",
                table: "ServicoSolicitado",
                column: "IdFuncionario",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServicoSolicitado_Servico_IdServico",
                table: "ServicoSolicitado",
                column: "IdServico",
                principalTable: "Servico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
