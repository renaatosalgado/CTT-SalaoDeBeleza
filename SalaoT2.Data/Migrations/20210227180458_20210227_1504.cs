using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalaoT2.Data.Migrations
{
    public partial class _20210227_1504 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Turno_TurnoId",
                table: "Funcionario");

            migrationBuilder.AlterColumn<Guid>(
                name: "TurnoId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Turno_TurnoId",
                table: "Funcionario",
                column: "TurnoId",
                principalTable: "Turno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Turno_TurnoId",
                table: "Funcionario");

            migrationBuilder.AlterColumn<Guid>(
                name: "TurnoId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Turno_TurnoId",
                table: "Funcionario",
                column: "TurnoId",
                principalTable: "Turno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
