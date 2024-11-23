﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using GerenciadorApi.Models;

namespace gerenciador_api.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20210420182702_ProdutoColunaPercentualNullable")]
    partial class ProdutoColunaPercentualNullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("GerenciadorApi.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("AtualizadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Nome")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AtualizadoEm = new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(423),
                            CriadoEm = new DateTime(2021, 4, 20, 15, 27, 2, 454, DateTimeKind.Local).AddTicks(8946),
                            Nome = "Refrigerante"
                        },
                        new
                        {
                            Id = 2,
                            AtualizadoEm = new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(737),
                            CriadoEm = new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(733),
                            Nome = "Cerveja"
                        },
                        new
                        {
                            Id = 3,
                            AtualizadoEm = new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(741),
                            CriadoEm = new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(740),
                            Nome = "Vodka"
                        },
                        new
                        {
                            Id = 4,
                            AtualizadoEm = new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(744),
                            CriadoEm = new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(743),
                            Nome = "Wisk"
                        },
                        new
                        {
                            Id = 5,
                            AtualizadoEm = new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(747),
                            CriadoEm = new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(746),
                            Nome = "Agua"
                        },
                        new
                        {
                            Id = 6,
                            AtualizadoEm = new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(750),
                            CriadoEm = new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(748),
                            Nome = "Suco"
                        },
                        new
                        {
                            Id = 7,
                            AtualizadoEm = new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(752),
                            CriadoEm = new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(751),
                            Nome = "Narglê"
                        },
                        new
                        {
                            Id = 8,
                            AtualizadoEm = new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(755),
                            CriadoEm = new DateTime(2021, 4, 20, 15, 27, 2, 456, DateTimeKind.Local).AddTicks(754),
                            Nome = "Cigarro"
                        });
                });

            modelBuilder.Entity("GerenciadorApi.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("AtualizadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("integer");

                    b.Property<string>("CodigoBarras")
                        .HasColumnType("text");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Foto")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("Nome")
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<double?>("PercentualImposto")
                        .HasColumnType("double precision");

                    b.Property<double>("ValorCompra")
                        .HasColumnType("double precision");

                    b.Property<double>("ValorVenda")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("GerenciadorApi.Models.Produto", b =>
                {
                    b.HasOne("GerenciadorApi.Models.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("GerenciadorApi.Models.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
