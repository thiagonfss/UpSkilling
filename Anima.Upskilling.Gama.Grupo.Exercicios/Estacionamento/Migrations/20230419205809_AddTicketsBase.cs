using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Estacionamento.Migrations
{
    /// <inheritdoc />
    public partial class AddTicketsBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false),
                    Entrada = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    Saida = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IdCliente = table.Column<int>(type: "integer", nullable: false),
                    NomeCliente = table.Column<string>(type: "text", nullable: true),
                    IdVeiculo = table.Column<int>(type: "integer", nullable: true),
                    DescricaoVeiculo = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");
        }
    }
}
