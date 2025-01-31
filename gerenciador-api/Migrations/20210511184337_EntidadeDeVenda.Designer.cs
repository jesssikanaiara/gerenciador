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
    [Migration("20210511184337_EntidadeDeVenda")]
    partial class EntidadeDeVenda
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
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
                            AtualizadoEm = new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(5756),
                            CriadoEm = new DateTime(2021, 5, 11, 15, 43, 36, 775, DateTimeKind.Local).AddTicks(3583),
                            Nome = "Refrigerante"
                        },
                        new
                        {
                            Id = 2,
                            AtualizadoEm = new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6240),
                            CriadoEm = new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6232),
                            Nome = "Cerveja"
                        },
                        new
                        {
                            Id = 3,
                            AtualizadoEm = new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6244),
                            CriadoEm = new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6242),
                            Nome = "Vodka"
                        },
                        new
                        {
                            Id = 4,
                            AtualizadoEm = new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6247),
                            CriadoEm = new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6245),
                            Nome = "Wisk"
                        },
                        new
                        {
                            Id = 5,
                            AtualizadoEm = new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6250),
                            CriadoEm = new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6249),
                            Nome = "Agua"
                        },
                        new
                        {
                            Id = 6,
                            AtualizadoEm = new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6253),
                            CriadoEm = new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6252),
                            Nome = "Suco"
                        },
                        new
                        {
                            Id = 7,
                            AtualizadoEm = new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6257),
                            CriadoEm = new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6255),
                            Nome = "Narglê"
                        },
                        new
                        {
                            Id = 8,
                            AtualizadoEm = new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6260),
                            CriadoEm = new DateTime(2021, 5, 11, 15, 43, 36, 776, DateTimeKind.Local).AddTicks(6258),
                            Nome = "Cigarro"
                        });
                });

            modelBuilder.Entity("GerenciadorApi.Models.Cliente", b =>
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
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.Property<string>("Sobrenome")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("GerenciadorApi.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("AtualizadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CFOP")
                        .HasColumnType("text");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("integer");

                    b.Property<string>("CodigoBarras")
                        .HasColumnType("text");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Foto")
                        .HasMaxLength(1000)
                        .HasColumnType("character varying(1000)");

                    b.Property<string>("IcmsSituacaoTributaria")
                        .HasColumnType("text");

                    b.Property<string>("NCM")
                        .HasColumnType("text");

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

            modelBuilder.Entity("GerenciadorApi.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("AtualizadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("Data")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("JsonEnvioNfce")
                        .HasMaxLength(60000)
                        .HasColumnType("character varying(60000)");

                    b.Property<string>("JsonRetornoNfce")
                        .HasColumnType("text");

                    b.Property<int>("StatusProcessamentoNfce")
                        .HasMaxLength(60000)
                        .HasColumnType("integer");

                    b.Property<double>("TotalTributosVenda")
                        .HasColumnType("double precision");

                    b.Property<double>("ValorVenda")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Venda");
                });

            modelBuilder.Entity("GerenciadorApi.Models.VendaPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("AtualizadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("BandeiraCartao")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("IdVenda")
                        .HasColumnType("integer");

                    b.Property<string>("NumeroAutorizacao")
                        .HasColumnType("text");

                    b.Property<int>("TipoPagamento")
                        .HasColumnType("integer");

                    b.Property<double>("Valor")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("IdVenda");

                    b.ToTable("VendaPagamento");
                });

            modelBuilder.Entity("GerenciadorApi.Models.VendaProduto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("AtualizadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("CriadoEm")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("IdProduto")
                        .HasColumnType("integer");

                    b.Property<int>("IdVenda")
                        .HasColumnType("integer");

                    b.Property<int?>("ProdutoId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantidade")
                        .HasColumnType("integer");

                    b.Property<double>("Valor")
                        .HasColumnType("double precision");

                    b.Property<double>("ValorTributos")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("IdVenda");

                    b.HasIndex("ProdutoId");

                    b.ToTable("VendaProdutos");
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

            modelBuilder.Entity("GerenciadorApi.Models.VendaPagamento", b =>
                {
                    b.HasOne("GerenciadorApi.Models.Venda", "Venda")
                        .WithMany("Pagamentos")
                        .HasForeignKey("IdVenda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("GerenciadorApi.Models.VendaProduto", b =>
                {
                    b.HasOne("GerenciadorApi.Models.Venda", "Venda")
                        .WithMany("Produtos")
                        .HasForeignKey("IdVenda")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorApi.Models.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.Navigation("Produto");

                    b.Navigation("Venda");
                });

            modelBuilder.Entity("GerenciadorApi.Models.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("GerenciadorApi.Models.Venda", b =>
                {
                    b.Navigation("Pagamentos");

                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
