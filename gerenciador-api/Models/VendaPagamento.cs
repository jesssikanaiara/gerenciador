using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorApi.Models
{
    public class VendaPagamento : ModeloBase
    {
        public string NumeroAutorizacao { get; set; }
        public double Valor { get; set; }
        public EnumTipoFormaPagamento TipoPagamento { get; set; }
        public EnumTipoBandeiraCartao? BandeiraCartao { get; set; }
        public int IdVenda { get; set; }
        public Venda Venda { get; set; }
    }

    public class VendaPagamentoConfig : ModeloBaseConfig<VendaPagamento>
    {
        public override void Configure(EntityTypeBuilder<VendaPagamento> builder)
        {
            base.Configure(builder);
            builder.Property(e => e.TipoPagamento).HasConversion<int>(); 
            builder.Property(e => e.BandeiraCartao).HasConversion<int>(); 
            builder.HasOne(x => x.Venda).WithMany(x => x.Pagamentos).HasForeignKey(x => x.IdVenda).IsRequired();    
        }
    }
}
