using System.Collections.Generic;
using FluentValidation;
using GerenciadorApi.Models;

namespace GerenciadorApi.ViewModels
{
    public class VendaVM
    {
        public List<VendaProdutoVM> Produtos { get; set; }
        public List<VendaPagamentoVM> Pagamentos { get; set; }
    }
    public class VendaPagamentoVM
    {
        public string NumeroAutorizacao { get; set; }
        public double Valor { get; set; }
        public EnumTipoFormaPagamento TipoPagamento { get; set; }
        public EnumTipoBandeiraCartao? BandeiraCartao { get; set; }
    }

    public class VendaProdutoVM
    {
        public int IdProduto { get; set; }
        public int Quantidade { get; set; }
    }

     public class VendaVMValidator : AbstractValidator<VendaVM>{
        public VendaVMValidator()
        {
            RuleFor(x => x.Produtos).NotNull().NotEmpty().WithMessage("Não é possível salvar uma venda sem produtos");
            RuleFor(x => x.Pagamentos).NotNull().NotEmpty().WithMessage("Não é possível salvar uma venda sem pagamentos");
        }
    }
}