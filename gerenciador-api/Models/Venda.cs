using System;
using System.Collections.Generic;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorApi.Models
{
    public class Venda : ModeloBase
    {
        public double ValorVenda { get; set; }
        public double TotalTributosVenda { get; set; }
        public DateTime Data { get; set; }
        public int StatusProcessamentoNfce { get; set; }
        public string JsonEnvioNfce { get; set; }
        public string JsonRetornoNfce { get; set; }

        public List<VendaProduto> Produtos { get; set; }
        public List<VendaPagamento> Pagamentos { get; set; }
    }

    public class VendaConfig : ModeloBaseConfig<Venda>
    {
        public override void Configure(EntityTypeBuilder<Venda> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.JsonEnvioNfce).HasMaxLength(60000);
            builder.Property(x => x.StatusProcessamentoNfce).HasMaxLength(60000);
        }
    }    
}
