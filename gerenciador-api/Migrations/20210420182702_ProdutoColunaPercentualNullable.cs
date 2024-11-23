using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gerenciador_api.Migrations
{
    public partial class ProdutoColunaPercentualNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "PercentualImposto",
                table: "Produtos",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "PercentualImposto",
                table: "Produtos",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 11, 12, 29, 32, 835, DateTimeKind.Local).AddTicks(8903), new DateTime(2021, 4, 11, 12, 29, 32, 833, DateTimeKind.Local).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 11, 12, 29, 32, 835, DateTimeKind.Local).AddTicks(9394), new DateTime(2021, 4, 11, 12, 29, 32, 835, DateTimeKind.Local).AddTicks(9388) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 11, 12, 29, 32, 835, DateTimeKind.Local).AddTicks(9398), new DateTime(2021, 4, 11, 12, 29, 32, 835, DateTimeKind.Local).AddTicks(9396) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 11, 12, 29, 32, 835, DateTimeKind.Local).AddTicks(9403), new DateTime(2021, 4, 11, 12, 29, 32, 835, DateTimeKind.Local).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 11, 12, 29, 32, 835, DateTimeKind.Local).AddTicks(9407), new DateTime(2021, 4, 11, 12, 29, 32, 835, DateTimeKind.Local).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 11, 12, 29, 32, 835, DateTimeKind.Local).AddTicks(9411), new DateTime(2021, 4, 11, 12, 29, 32, 835, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 11, 12, 29, 32, 835, DateTimeKind.Local).AddTicks(9418), new DateTime(2021, 4, 11, 12, 29, 32, 835, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 11, 12, 29, 32, 835, DateTimeKind.Local).AddTicks(9422), new DateTime(2021, 4, 11, 12, 29, 32, 835, DateTimeKind.Local).AddTicks(9421) });
        }
    }
}
