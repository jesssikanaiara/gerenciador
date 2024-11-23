using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace gerenciador_api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    ValorVenda = table.Column<double>(type: "double precision", nullable: false),
                    ValorCompra = table.Column<double>(type: "double precision", nullable: false),
                    PercentualImposto = table.Column<double>(type: "double precision", nullable: false),
                    Foto = table.Column<string>(type: "text", nullable: true),
                    CategoriaId = table.Column<int>(type: "integer", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "AtualizadoEm", "CriadoEm", "Nome" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3083), new DateTime(2021, 4, 4, 21, 12, 31, 836, DateTimeKind.Local).AddTicks(4552), "Refrigerante" },
                    { 2, new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3850), new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3836), "Cerveja" },
                    { 3, new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3854), new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3852), "Vodka" },
                    { 4, new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3859), new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3857), "Wisk" },
                    { 5, new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3863), new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3861), "Agua" },
                    { 6, new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3867), new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3865), "Suco" },
                    { 7, new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3871), new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3870), "Narglê" },
                    { 8, new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3876), new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3874), "Cigarro" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
