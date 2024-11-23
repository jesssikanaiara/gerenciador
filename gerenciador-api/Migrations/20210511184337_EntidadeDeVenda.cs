using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace gerenciador_api.Migrations
{
    public partial class EntidadeDeVenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CFOP",
                table: "Produtos",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IcmsSituacaoTributaria",
                table: "Produtos",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NCM",
                table: "Produtos",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ValorVenda = table.Column<double>(type: "double precision", nullable: false),
                    TotalTributosVenda = table.Column<double>(type: "double precision", nullable: false),
                    Data = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    StatusProcessamentoNfce = table.Column<int>(type: "integer", maxLength: 60000, nullable: false),
                    JsonEnvioNfce = table.Column<string>(type: "character varying(60000)", maxLength: 60000, nullable: true),
                    JsonRetornoNfce = table.Column<string>(type: "text", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VendaPagamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NumeroAutorizacao = table.Column<string>(type: "text", nullable: true),
                    Valor = table.Column<double>(type: "double precision", nullable: false),
                    TipoPagamento = table.Column<int>(type: "integer", nullable: false),
                    BandeiraCartao = table.Column<int>(type: "integer", nullable: false),
                    IdVenda = table.Column<int>(type: "integer", nullable: false),
                    CriadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaPagamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendaPagamento_Venda_IdVenda",
                        column: x => x.IdVenda,
                        principalTable: "Venda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VendaProdutos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Valor = table.Column<double>(type: "double precision", nullable: false),
                    Quantidade = table.Column<int>(type: "integer", nullable: false),
                    ValorTributos = table.Column<double>(type: "double precision", nullable: false),
                    IdVenda = table.Column<int>(type: "integer", nullable: false),
                    IdProduto = table.Column<int>(type: "integer", nullable: false),
                    ProdutoId = table.Column<int>(type: "integer", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendaProdutos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VendaProdutos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VendaProdutos_Venda_IdVenda",
                        column: x => x.IdVenda,
                        principalTable: "Venda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(5756), new DateTime(2021, 5, 11, 15, 43, 36, 775, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6240), new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6244), new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6247), new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6245) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6250), new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6253), new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6257), new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6255) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6260), new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.CreateIndex(
                name: "IX_VendaPagamento_IdVenda",
                table: "VendaPagamento",
                column: "IdVenda");

            migrationBuilder.CreateIndex(
                name: "IX_VendaProdutos_IdVenda",
                table: "VendaProdutos",
                column: "IdVenda");

            migrationBuilder.CreateIndex(
                name: "IX_VendaProdutos_ProdutoId",
                table: "VendaProdutos",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendaPagamento");

            migrationBuilder.DropTable(
                name: "VendaProdutos");

            migrationBuilder.DropTable(
                name: "Venda");

            migrationBuilder.DropColumn(
                name: "CFOP",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "IcmsSituacaoTributaria",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "NCM",
                table: "Produtos");

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
    }
}
