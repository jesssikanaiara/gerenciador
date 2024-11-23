using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace gerenciador_api.Migrations
{
    public partial class AddUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Perfis",
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
                    table.PrimaryKey("PK_Perfis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nome = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    PerfilId = table.Column<int>(type: "integer", nullable: false),
                    Senha = table.Column<string>(type: "text", nullable: true),
                    CriadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AtualizadoEm = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuarios_Perfis_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Perfis",
                columns: new[] { "Id", "AtualizadoEm", "CriadoEm", "Nome" },
                values: new object[] { 1, new DateTime(2021, 6, 29, 21, 25, 56, 579, DateTimeKind.Local).AddTicks(2421), new DateTime(2021, 6, 29, 21, 25, 56, 579, DateTimeKind.Local).AddTicks(2479), "Admin" });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "AtualizadoEm", "CriadoEm", "Email", "Nome", "PerfilId", "Senha" },
                values: new object[] { 1, new DateTime(2021, 6, 29, 21, 25, 56, 608, DateTimeKind.Local).AddTicks(9472), new DateTime(2021, 6, 29, 21, 25, 56, 608, DateTimeKind.Local).AddTicks(9537), "admin@admin.com", "Admin", 1, "QBafXnhDjymCXvR3WksU0Hv+R2UXuPSIp7zOuwhg0Rs=" });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PerfilId",
                table: "Usuarios",
                column: "PerfilId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Perfis");

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
        }
    }
}
