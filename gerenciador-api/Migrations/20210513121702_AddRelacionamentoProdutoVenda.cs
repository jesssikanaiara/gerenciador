using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gerenciador_api.Migrations
{
    public partial class AddRelacionamentoProdutoVenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaProdutos_Produtos_ProdutoId",
                table: "VendaProdutos");

            migrationBuilder.DropIndex(
                name: "IX_VendaProdutos_ProdutoId",
                table: "VendaProdutos");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "VendaProdutos");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 5, 13, 9, 17, 2, 64, DateTimeKind.Local).AddTicks(3822), new DateTime(2021, 5, 13, 9, 17, 2, 62, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 5, 13, 9, 17, 2, 64, DateTimeKind.Local).AddTicks(4579), new DateTime(2021, 5, 13, 9, 17, 2, 64, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 5, 13, 9, 17, 2, 64, DateTimeKind.Local).AddTicks(4584), new DateTime(2021, 5, 13, 9, 17, 2, 64, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 5, 13, 9, 17, 2, 64, DateTimeKind.Local).AddTicks(4590), new DateTime(2021, 5, 13, 9, 17, 2, 64, DateTimeKind.Local).AddTicks(4588) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 5, 13, 9, 17, 2, 64, DateTimeKind.Local).AddTicks(4594), new DateTime(2021, 5, 13, 9, 17, 2, 64, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 5, 13, 9, 17, 2, 64, DateTimeKind.Local).AddTicks(4598), new DateTime(2021, 5, 13, 9, 17, 2, 64, DateTimeKind.Local).AddTicks(4597) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 5, 13, 9, 17, 2, 64, DateTimeKind.Local).AddTicks(4604), new DateTime(2021, 5, 13, 9, 17, 2, 64, DateTimeKind.Local).AddTicks(4601) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 5, 13, 9, 17, 2, 64, DateTimeKind.Local).AddTicks(4608), new DateTime(2021, 5, 13, 9, 17, 2, 64, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.CreateIndex(
                name: "IX_VendaProdutos_IdProduto",
                table: "VendaProdutos",
                column: "IdProduto");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaProdutos_Produtos_IdProduto",
                table: "VendaProdutos",
                column: "IdProduto",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VendaProdutos_Produtos_IdProduto",
                table: "VendaProdutos");

            migrationBuilder.DropIndex(
                name: "IX_VendaProdutos_IdProduto",
                table: "VendaProdutos");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "VendaProdutos",
                type: "integer",
                nullable: true);

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
                name: "IX_VendaProdutos_ProdutoId",
                table: "VendaProdutos",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_VendaProdutos_Produtos_ProdutoId",
                table: "VendaProdutos",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
