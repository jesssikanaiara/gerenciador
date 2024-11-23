using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorApi.Models
{
    public class VendaProduto : ModeloBase
    {
        public double Valor { get; set; }
        public int Quantidade { get; set; }
        public double ValorTotal { get => this.Valor * (double)this.Quantidade; }
        public double ValorTributos { get; set; }        
        public int IdVenda { get; set; }
        public int IdProduto { get; set; }

        public Venda Venda { get; set; }
        public Produto Produto { get; set; }
    }

    public class VendaProdutoConfig : ModeloBaseConfig<VendaProduto>
    {
        public override void Configure(EntityTypeBuilder<VendaProduto> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Venda).WithMany(x => x.Produtos).HasForeignKey(x => x.IdVenda).IsRequired();    
            builder.HasOne(x => x.Produto).WithMany(x => x.Vendas).HasForeignKey(x => x.IdProduto).IsRequired();    
        }
    }
}
