using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GerenciadorApi.Models;

namespace GerenciadorApi.ViewModels
{
    public class ProdutoVM : ModeloBaseVM
    {
        public string CodigoBarras { get; set; }        
        public string Nome { get; set; }
        public double ValorVenda { get; set; }
        public double ValorCompra { get; set; }
        public double? PercentualImposto { get; set; }
        public string Foto { get; set; }
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
    }
    
}