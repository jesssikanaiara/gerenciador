using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace gerenciador_api.Migrations
{
    public partial class AdicionandoCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    Sobrenome = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: true),
                    Telefone = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 27, 22, 55, 36, 198, DateTimeKind.Local).AddTicks(2639), new DateTime(2021, 4, 27, 22, 55, 36, 197, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 27, 22, 55, 36, 198, DateTimeKind.Local).AddTicks(2947), new DateTime(2021, 4, 27, 22, 55, 36, 198, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 27, 22, 55, 36, 198, DateTimeKind.Local).AddTicks(2949), new DateTime(2021, 4, 27, 22, 55, 36, 198, DateTimeKind.Local).AddTicks(2948) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 27, 22, 55, 36, 198, DateTimeKind.Local).AddTicks(2952), new DateTime(2021, 4, 27, 22, 55, 36, 198, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 27, 22, 55, 36, 198, DateTimeKind.Local).AddTicks(2955), new DateTime(2021, 4, 27, 22, 55, 36, 198, DateTimeKind.Local).AddTicks(2954) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 27, 22, 55, 36, 198, DateTimeKind.Local).AddTicks(2958), new DateTime(2021, 4, 27, 22, 55, 36, 198, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 27, 22, 55, 36, 198, DateTimeKind.Local).AddTicks(2961), new DateTime(2021, 4, 27, 22, 55, 36, 198, DateTimeKind.Local).AddTicks(2960) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 27, 22, 55, 36, 198, DateTimeKind.Local).AddTicks(2964), new DateTime(2021, 4, 27, 22, 55, 36, 198, DateTimeKind.Local).AddTicks(2962) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(423), new DateTime(2021, 4, 20, 15, 27, 2, 454, DateTimeKind.Local).AddTicks(8946) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(737), new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(733) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(741), new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(740) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(744), new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(743) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(747), new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(746) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(750), new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(748) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(752), new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(751) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(755), new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(754) });
        }
    }
}
