using System.Collections.Generic;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorApi.Models
{
    public class Produto : ModeloBase
    {
        public string CodigoBarras { get; set; }
        public string Nome { get; set; }
        public double ValorVenda { get; set; }
        public double ValorCompra { get; set; }
        public double? PercentualImposto { get; set; }
        public string Foto { get; set; }
        public string NCM { get; set; }
        public string CFOP { get; set; }
        public string IcmsSituacaoTributaria { get; set; }
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
        public List<VendaProduto> Vendas { get; set; }
    }

    public class ProdutoConfig : ModeloBaseConfig<Produto>
    {
        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            base.Configure(builder);
            builder.HasOne(x => x.Categoria).WithMany(x => x.Produtos).HasForeignKey(x => x.CategoriaId).IsRequired();
            builder.Property(x => x.Nome).HasMaxLength(250);      
            builder.Property(x => x.Foto).HasMaxLength(1000);      
        }
    }

    public class ProdutoValidator : AbstractValidator<Produto>{
        public ProdutoValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Nome do produto é obrigatório");
            RuleFor(x => x.Nome).MaximumLength(250).WithMessage("Nome do produto pode ter no máximo 250 caracteres");
            RuleFor(x => x.CategoriaId).GreaterThan(0).WithMessage("Categoria é obrigatória");
        }
    }
}