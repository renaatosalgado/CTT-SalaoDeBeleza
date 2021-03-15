using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalaoT2.Data.Migrations
{
    public partial class _20210227_1353 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServicoSolicitado_Funcionario_FuncionarioId",
                table: "ServicoSolicitado");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicoSolicitado_Servico_ServicoId",
                table: "ServicoSolicitado");

            migrationBuilder.DropColumn(
                name: "IdFuncionario",
                table: "ServicoSolicitado");

            migrationBuilder.DropColumn(
                name: "IdServico",
                table: "ServicoSolicitado");

            migrationBuilder.DropColumn(
                name: "DtAgendamento",
                table: "Agendamento");

            migrationBuilder.AlterColumn<Guid>(
                name: "ServicoId",
                table: "ServicoSolicitado",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FuncionarioId",
                table: "ServicoSolicitado",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataAgendamento",
                table: "Agendamento",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Turno",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoTurno = table.Column<int>(type: "int", nullable: false),
                    EntradaSemana = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaidaSemana = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntradaSabado = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SaidaSabado = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turno", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ServicoSolicitado_Funcionario_FuncionarioId",
                table: "ServicoSolicitado",
                column: "FuncionarioId",
                principalTable: "Funcionario",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServicoSolicitado_Servico_ServicoId",
                table: "ServicoSolicitado",
                column: "ServicoId",
                principalTable: "Servico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServicoSolicitado_Funcionario_FuncionarioId",
                table: "ServicoSolicitado");

            migrationBuilder.DropForeignKey(
                name: "FK_ServicoSolicitado_Servico_ServicoId",
                table: "ServicoSolicitado");

            migrationBuilder.DropTable(
                name: "Turno");

            migrationBuilder.DropColumn(
                name: "DataAgendamento",
                table: "Agendamento");

            migrationBuilder.AlterColumn<Guid>(
                name: "ServicoId",
                table: "ServicoSolicitado",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "FuncionarioId",
                table: "ServicoSolicitado",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "IdFuncionario",
                table: "ServicoSolicitado",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdServico",
                table: "ServicoSolicitado",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "DtAgendamento",
                table: "Agendamento",
                type: "datetime2",
                nullable: true);

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
    }
}
