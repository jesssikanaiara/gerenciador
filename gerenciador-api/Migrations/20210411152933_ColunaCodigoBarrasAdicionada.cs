using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace gerenciador_api.Migrations
{
    public partial class ColunaCodigoBarrasAdicionada : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                type: "character varying(250)",
                maxLength: 250,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Foto",
                table: "Produtos",
                type: "character varying(1000)",
                maxLength: 1000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CodigoBarras",
                table: "Produtos",
                type: "text",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CodigoBarras",
                table: "Produtos");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(250)",
                oldMaxLength: 250,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Foto",
                table: "Produtos",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(1000)",
                oldMaxLength: 1000,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3083), new DateTime(2021, 4, 4, 21, 12, 31, 836, DateTimeKind.Local).AddTicks(4552) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3850), new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3836) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3854), new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3852) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3859), new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3857) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3863), new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3861) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3867), new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3865) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3871), new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3870) });

            migrationBuilder.UpdateData(
                table: "Categorias",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AtualizadoEm", "CriadoEm" },
                values: new object[] { new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3876), new DateTime(2021, 4, 4, 21, 12, 31, 838, DateTimeKind.Local).AddTicks(3874) });
        }
    }
}
