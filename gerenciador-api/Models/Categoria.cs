using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorApi.Models
{
    public class Categoria : ModeloBase
    {
        public string Nome { get; set; }
        public List<Produto> Produtos { get; set; }
    }

    public class CategoriaConfig : ModeloBaseConfig<Categoria>
    {
        public override void Configure(EntityTypeBuilder<Categoria> builder)
        {
            base.Configure(builder);            
        }
    }
}