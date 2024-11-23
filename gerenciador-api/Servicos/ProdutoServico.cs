using System.Collections.Generic;
using System.Linq;
using GerenciadorApi.Exceptions;
using GerenciadorApi.Models;
using GerenciadorApi.ViewModels;

namespace GerenciadorApi.Servicos
{
    public interface IProdutoServico
    {
        void Salvar(Produto produto);
        void Atualizar(int id, Produto produto);
        PaginacaoRetornoVM<ProdutoVM> ObterLista(PaginacaoFiltroVM filtro);
        Produto Detalhe(int id);
    }

    public class ProdutoServico : IProdutoServico
    {
        private DataBaseContext _db;

        public ProdutoServico(DataBaseContext db)
        {
            _db = db;
        }

        public void Salvar(Produto produto)
        {
            _db.Produtos.Add(produto);
            _db.SaveChanges();
        }

        public void Atualizar(int id, Produto produto)
        {
            var produtoDb = _db.Produtos.FirstOrDefault(x => x.Id == id);

            if(produtoDb == null)
                throw new ValidacaoException("Produto não existe");

            produtoDb.Nome = produto.Nome;
            produtoDb.Foto = produto.Foto;
            produtoDb.NCM = produto.NCM;
            produtoDb.PercentualImposto = produto.PercentualImposto;
            produtoDb.ValorCompra = produto.ValorCompra;
            produtoDb.ValorVenda = produto.ValorVenda;
            produtoDb.CategoriaId = produto.CategoriaId;
            produtoDb.CFOP = produto.CFOP;
            produtoDb.CodigoBarras = produto.CodigoBarras;
            produtoDb.IcmsSituacaoTributaria = produto.IcmsSituacaoTributaria;
                        
            _db.SaveChanges();
        }
    
        public PaginacaoRetornoVM<ProdutoVM> ObterLista(PaginacaoFiltroVM parametro)
        {
            var query = _db.Produtos.Where(x => x.Nome.ToLower().Contains(parametro.Filtro)
                                             || x.CodigoBarras.ToLower().Contains(parametro.Filtro))
                                    .OrderBy(x => x.Nome)
                                    .AsQueryable();

            if (parametro.Pagina > 1)
                query = query.Skip(parametro.ItensPorPagina * (parametro.Pagina - 1)).AsQueryable();

            var lista = query.Take(parametro.ItensPorPagina)
                             .Select(x => new ProdutoVM
                             {
                                 Id = x.Id,
                                 CodigoBarras = x.CodigoBarras,
                                 AtualizadoEm = x.AtualizadoEm,
                                 CategoriaId = x.CategoriaId,
                                 CategoriaNome = x.Categoria.Nome,
                                 CriadoEm = x.CriadoEm,
                                 Foto = x.Foto,
                                 Nome = x.Nome,
                                 PercentualImposto = x.PercentualImposto,
                                 ValorCompra = x.ValorCompra,
                                 ValorVenda = x.ValorVenda                                 
                             })
                             .ToList();
                             
            var total = query.Count();
            
            return new PaginacaoRetornoVM<ProdutoVM>(lista, total);
        }

        public Produto Detalhe(int id){
            var produtoDb = _db.Produtos.FirstOrDefault(x => x.Id == id);

            if(produtoDb == null)
                throw new ValidacaoException("Produto não existe");

            return produtoDb;
        }
    }
}