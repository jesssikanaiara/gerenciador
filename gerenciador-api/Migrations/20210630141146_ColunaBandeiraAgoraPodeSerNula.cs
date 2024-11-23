using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gerenciador_api.Migrations
{
    public partial class ColunaBandeiraAgoraPodeSerNula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BandeiraCartao",
                table: "VendaPagamento",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 30, 11, 11, 45, 203, DateTimeKind.Local).AddTicks(32), new DateTime(2021, 6, 30, 11, 11, 45, 200, DateTimeKind.Local).AddTicks(3583) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 30, 11, 11, 45, 203, DateTimeKind.Local).AddTicks(675), new DateTime(2021, 6, 30, 11, 11, 45, 203, DateTimeKind.Local).AddTicks(668) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 30, 11, 11, 45, 203, DateTimeKind.Local).AddTicks(680), new DateTime(2021, 6, 30, 11, 11, 45, 203, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 30, 11, 11, 45, 203, DateTimeKind.Local).AddTicks(685), new DateTime(2021, 6, 30, 11, 11, 45, 203, DateTimeKind.Local).AddTicks(683) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 30, 11, 11, 45, 203, DateTimeKind.Local).AddTicks(690), new DateTime(2021, 6, 30, 11, 11, 45, 203, DateTimeKind.Local).AddTicks(688) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 30, 11, 11, 45, 203, DateTimeKind.Local).AddTicks(696), new DateTime(2021, 6, 30, 11, 11, 45, 203, DateTimeKind.Local).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 30, 11, 11, 45, 203, DateTimeKind.Local).AddTicks(701), new DateTime(2021, 6, 30, 11, 11, 45, 203, DateTimeKind.Local).AddTicks(699) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 30, 11, 11, 45, 203, DateTimeKind.Local).AddTicks(706), new DateTime(2021, 6, 30, 11, 11, 45, 203, DateTimeKind.Local).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 30, 11, 11, 45, 205, DateTimeKind.Local).AddTicks(2711), new DateTime(2021, 6, 30, 11, 11, 45, 205, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 30, 11, 11, 45, 230, DateTimeKind.Local).AddTicks(2618), new DateTime(2021, 6, 30, 11, 11, 45, 230, DateTimeKind.Local).AddTicks(2693) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BandeiraCartao",
                table: "VendaPagamento",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 29, 21, 25, 56, 576, DateTimeKind.Local).AddTicks(6414), new DateTime(2021, 6, 29, 21, 25, 56, 574, DateTimeKind.Local).AddTicks(312) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 29, 21, 25, 56, 576, DateTimeKind.Local).AddTicks(7151), new DateTime(2021, 6, 29, 21, 25, 56, 576, DateTimeKind.Local).AddTicks(7143) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 29, 21, 25, 56, 576, DateTimeKind.Local).AddTicks(7158), new DateTime(2021, 6, 29, 21, 25, 56, 576, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 29, 21, 25, 56, 576, DateTimeKind.Local).AddTicks(7163), new DateTime(2021, 6, 29, 21, 25, 56, 576, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 29, 21, 25, 56, 576, DateTimeKind.Local).AddTicks(7168), new DateTime(2021, 6, 29, 21, 25, 56, 576, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 29, 21, 25, 56, 576, DateTimeKind.Local).AddTicks(7173), new DateTime(2021, 6, 29, 21, 25, 56, 576, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 29, 21, 25, 56, 576, DateTimeKind.Local).AddTicks(7178), new DateTime(2021, 6, 29, 21, 25, 56, 576, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 29, 21, 25, 56, 576, DateTimeKind.Local).AddTicks(7183), new DateTime(2021, 6, 29, 21, 25, 56, 576, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "Perfis",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 29, 21, 25, 56, 579, DateTimeKind.Local).AddTicks(2421), new DateTime(2021, 6, 29, 21, 25, 56, 579, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 6, 29, 21, 25, 56, 608, DateTimeKind.Local).AddTicks(9472), new DateTime(2021, 6, 29, 21, 25, 56, 608, DateTimeKind.Local).AddTicks(9537) });
        }
    }
}
