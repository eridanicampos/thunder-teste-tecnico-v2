using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Thunders.TechTest.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateRelatorios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "id",
                table: "utilizacoes");

            migrationBuilder.DropColumn(
                name: "cidade",
                table: "utilizacoes");

            migrationBuilder.DropColumn(
                name: "estado",
                table: "utilizacoes");

            migrationBuilder.DropColumn(
                name: "praca",
                table: "utilizacoes");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "utilizacoes",
                newName: "id");

            migrationBuilder.AddColumn<DateTime>(
                name: "created_at",
                table: "utilizacoes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                comment: "When this entity was created in this DB");

            migrationBuilder.AddColumn<string>(
                name: "created_by_user_id",
                table: "utilizacoes",
                type: "VARCHAR(100)",
                nullable: false,
                defaultValue: "",
                comment: "The id of the user who did create");

            migrationBuilder.AddColumn<DateTime>(
                name: "deleted_at",
                table: "utilizacoes",
                type: "datetime2",
                nullable: true,
                comment: "When this entity was deleted in this DB");

            migrationBuilder.AddColumn<string>(
                name: "deleted_by_user_id",
                table: "utilizacoes",
                type: "VARCHAR(100)",
                nullable: true,
                comment: "The id of the user who did the delete");

            migrationBuilder.AddColumn<bool>(
                name: "is_deleted",
                table: "utilizacoes",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "The field that identifies that the entity was deleted");

            migrationBuilder.AddColumn<Guid>(
                name: "praca_id",
                table: "utilizacoes",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<DateTime>(
                name: "update_at",
                table: "utilizacoes",
                type: "datetime2",
                nullable: true,
                comment: "When this entity was modified the last time");

            migrationBuilder.AddColumn<string>(
                name: "update_by_user_id",
                table: "utilizacoes",
                type: "VARCHAR(100)",
                nullable: true,
                comment: "The id of the user who did the last modification");

            migrationBuilder.AddPrimaryKey(
                name: "PK_utilizacoes",
                table: "utilizacoes",
                column: "id");

            migrationBuilder.CreateTable(
                name: "pracas",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    estado = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    created_by_user_id = table.Column<string>(type: "VARCHAR(100)", nullable: false, comment: "The id of the user who did create"),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "When this entity was created in this DB"),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "When this entity was modified the last time"),
                    update_by_user_id = table.Column<string>(type: "VARCHAR(100)", nullable: true, comment: "The id of the user who did the last modification"),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false, comment: "The field that identifies that the entity was deleted"),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "When this entity was deleted in this DB"),
                    deleted_by_user_id = table.Column<string>(type: "VARCHAR(100)", nullable: true, comment: "The id of the user who did the delete")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pracas", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "relatorio_tipos_veiculos_praca",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome_praca = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    tipo_veiculo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    quantidade = table.Column<int>(type: "int", nullable: false),
                    data_relatorio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by_user_id = table.Column<string>(type: "VARCHAR(100)", nullable: false, comment: "The id of the user who did create"),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "When this entity was created in this DB"),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "When this entity was modified the last time"),
                    update_by_user_id = table.Column<string>(type: "VARCHAR(100)", nullable: true, comment: "The id of the user who did the last modification"),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false, comment: "The field that identifies that the entity was deleted"),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "When this entity was deleted in this DB"),
                    deleted_by_user_id = table.Column<string>(type: "VARCHAR(100)", nullable: true, comment: "The id of the user who did the delete")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relatorio_tipos_veiculos_praca", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "relatorio_top_pracas_mes",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nome_praca = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    valor_total = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    ano = table.Column<int>(type: "int", nullable: false),
                    mes = table.Column<int>(type: "int", nullable: false),
                    data_relatorio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by_user_id = table.Column<string>(type: "VARCHAR(100)", nullable: false, comment: "The id of the user who did create"),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "When this entity was created in this DB"),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "When this entity was modified the last time"),
                    update_by_user_id = table.Column<string>(type: "VARCHAR(100)", nullable: true, comment: "The id of the user who did the last modification"),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false, comment: "The field that identifies that the entity was deleted"),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "When this entity was deleted in this DB"),
                    deleted_by_user_id = table.Column<string>(type: "VARCHAR(100)", nullable: true, comment: "The id of the user who did the delete")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relatorio_top_pracas_mes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "relatorio_valor_hora_cidade",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    cidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    hora = table.Column<int>(type: "int", nullable: false),
                    valor_total = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    data_relatorio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    created_by_user_id = table.Column<string>(type: "VARCHAR(100)", nullable: false, comment: "The id of the user who did create"),
                    created_at = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "When this entity was created in this DB"),
                    update_at = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "When this entity was modified the last time"),
                    update_by_user_id = table.Column<string>(type: "VARCHAR(100)", nullable: true, comment: "The id of the user who did the last modification"),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false, comment: "The field that identifies that the entity was deleted"),
                    deleted_at = table.Column<DateTime>(type: "datetime2", nullable: true, comment: "When this entity was deleted in this DB"),
                    deleted_by_user_id = table.Column<string>(type: "VARCHAR(100)", nullable: true, comment: "The id of the user who did the delete")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_relatorio_valor_hora_cidade", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_utilizacoes_praca_id",
                table: "utilizacoes",
                column: "praca_id");

            migrationBuilder.AddForeignKey(
                name: "FK_utilizacoes_pracas_praca_id",
                table: "utilizacoes",
                column: "praca_id",
                principalTable: "pracas",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_utilizacoes_pracas_praca_id",
                table: "utilizacoes");

            migrationBuilder.DropTable(
                name: "pracas");

            migrationBuilder.DropTable(
                name: "relatorio_tipos_veiculos_praca");

            migrationBuilder.DropTable(
                name: "relatorio_top_pracas_mes");

            migrationBuilder.DropTable(
                name: "relatorio_valor_hora_cidade");

            migrationBuilder.DropPrimaryKey(
                name: "PK_utilizacoes",
                table: "utilizacoes");

            migrationBuilder.DropIndex(
                name: "IX_utilizacoes_praca_id",
                table: "utilizacoes");

            migrationBuilder.DropColumn(
                name: "created_at",
                table: "utilizacoes");

            migrationBuilder.DropColumn(
                name: "created_by_user_id",
                table: "utilizacoes");

            migrationBuilder.DropColumn(
                name: "deleted_at",
                table: "utilizacoes");

            migrationBuilder.DropColumn(
                name: "deleted_by_user_id",
                table: "utilizacoes");

            migrationBuilder.DropColumn(
                name: "is_deleted",
                table: "utilizacoes");

            migrationBuilder.DropColumn(
                name: "praca_id",
                table: "utilizacoes");

            migrationBuilder.DropColumn(
                name: "update_at",
                table: "utilizacoes");

            migrationBuilder.DropColumn(
                name: "update_by_user_id",
                table: "utilizacoes");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "utilizacoes",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "cidade",
                table: "utilizacoes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "estado",
                table: "utilizacoes",
                type: "nvarchar(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "praca",
                table: "utilizacoes",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "id",
                table: "utilizacoes",
                column: "Id");
        }
    }
}
