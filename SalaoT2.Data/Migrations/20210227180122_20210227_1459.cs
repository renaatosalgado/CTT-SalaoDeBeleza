using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SalaoT2.Data.Migrations
{
    public partial class _20210227_1459 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Cargo",
                table: "Funcionario",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(2)");

            migrationBuilder.AddColumn<Guid>(
                name: "TurnoId",
                table: "Funcionario",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_TurnoId",
                table: "Funcionario",
                column: "TurnoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcionario_Turno_TurnoId",
                table: "Funcionario",
                column: "TurnoId",
                principalTable: "Turno",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcionario_Turno_TurnoId",
                table: "Funcionario");

            migrationBuilder.DropIndex(
                name: "IX_Funcionario_TurnoId",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "TurnoId",
                table: "Funcionario");

            migrationBuilder.AlterColumn<string>(
                name: "Cargo",
                table: "Funcionario",
                type: "varchar(2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
