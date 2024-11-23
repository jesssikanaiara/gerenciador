using FluentValidation;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorApi.Models
{
    public class Cliente : ModeloBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
    }

    public class ClienteConfig : ModeloBaseConfig<Cliente>
    {
        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Nome).HasMaxLength(250);      
            builder.Property(x => x.Sobrenome).HasMaxLength(1000);      
            builder.Property(x => x.Telefone).HasMaxLength(15);      
        }
    }

    public class ClienteValidator : AbstractValidator<Cliente>{
        public ClienteValidator()
        {
            RuleFor(x => x.Nome).NotEmpty().WithMessage("Nome do produto é obrigatório");
            RuleFor(x => x.Nome).MaximumLength(250).WithMessage("Nome do produto pode ter no máximo 250 caracteres");
        }
    }
}