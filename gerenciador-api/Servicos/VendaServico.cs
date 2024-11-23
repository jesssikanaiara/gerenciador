using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GerenciadorApi.Models;
using GerenciadorApi.ViewModels;

namespace GerenciadorApi.Servicos
{
    public interface IVendaServico
    {
        Task Salvar(VendaVM venda);
    }

    public class VendaServico : IVendaServico
    {
        private DataBaseContext _db;

        public VendaServico(DataBaseContext db)
        {
            _db = db;
        }

        public async Task Salvar(VendaVM venda)
        {
            using (var transation = _db.Database.BeginTransaction())
            {
                try
                {
                    var idProdutos = venda.Produtos.Select(x => x.IdProduto);
                    var produtos = _db.Produtos.Where(x => idProdutos.Contains(x.Id));

                    List<VendaProduto> produtosVenda = formatarProdutos(venda, produtos);

                    double valorTotalProdutos = produtosVenda.Sum(x => x.ValorTotal);
                    double valorTotalPagamentos = venda.Pagamentos.Sum(x => x.Valor);

                    if (valorTotalProdutos != valorTotalPagamentos)
                        throw new ArgumentException("O valor total dos pagamentos é divergente do valor da venda.");

                    Venda vendaDb = criarObjetoVenda(venda, produtosVenda, valorTotalPagamentos);

                    _db.Vendas.Add(vendaDb);
                    _db.SaveChanges();

                    vendaDb = _db.Vendas.Include(x => x.Produtos)
                                        .ThenInclude(x => x.Produto)
                                        .Include(x => x.Pagamentos)
                                        .FirstOrDefault(x => x.Id == vendaDb.Id);

                    transation.Commit();
                }
                catch (System.Exception)
                {
                    transation.Rollback();
                    throw new ArgumentException("Ocorreu um erro ao processar a venda");                    
                }
            }
        }

        private static Venda criarObjetoVenda(VendaVM venda, List<VendaProduto> produtosVenda, double valorTotalPagamentos)
        {
            var vendaDb = new Venda
            {
                Data = DateTime.Now,
                ValorVenda = valorTotalPagamentos,
                Pagamentos = venda.Pagamentos.Select(x => new Models.VendaPagamento
                {
                    NumeroAutorizacao = x.NumeroAutorizacao,
                    Valor = x.Valor,
                    TipoPagamento = x.TipoPagamento,
                    BandeiraCartao = x.TipoPagamento == EnumTipoFormaPagamento.CartaoCredito || x.TipoPagamento == EnumTipoFormaPagamento.CartaoDebito ? x.BandeiraCartao : null
                }).ToList(),
                Produtos = produtosVenda,
                TotalTributosVenda = produtosVenda.Sum(x => x.ValorTributos)
            };

            return vendaDb;
        }

        private static List<VendaProduto> formatarProdutos(VendaVM venda, IQueryable<Produto> produtos)
        {
            var produtosVenda = new List<VendaProduto>();

            foreach (var produtoVenda in venda.Produtos)
            {
                var produto = produtos.FirstOrDefault(x => x.Id == produtoVenda.IdProduto);

                var item = new VendaProduto()
                {
                    IdProduto = produto.Id,
                    Valor = produto.ValorVenda,
                    Quantidade = produtoVenda.Quantidade,
                    ValorTributos = produto.PercentualImposto.HasValue ? produto.ValorVenda * (produto.PercentualImposto.Value / 100) : 0
                };

                produtosVenda.Add(item);
            }

            return produtosVenda;
        }
    }
}