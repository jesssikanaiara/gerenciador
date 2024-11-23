using System.Collections.Generic;
using System.Linq;
using GerenciadorApi.Models;
using GerenciadorApi.ViewModels;

namespace GerenciadorApi.Servicos
{
    public interface IClienteServico
    {
        void Salvar(Cliente cliente);
        PaginacaoRetornoVM<ClienteVM> ObterLista(PaginacaoFiltroVM filtro);
    }

    public class ClienteServico : IClienteServico
    {
        private DataBaseContext _db;

        public ClienteServico(DataBaseContext db)
        {
            _db = db;
        }

        public void Salvar(Cliente cliente)
        {
            _db.Clientes.Add(cliente);
            _db.SaveChanges();
        }

        public PaginacaoRetornoVM<ClienteVM> ObterLista(PaginacaoFiltroVM parametro)
        {
            var query = _db.Clientes.Where(x => x.Nome.ToLower().Contains(parametro.Filtro)
                                             || x.Sobrenome.ToLower().Contains(parametro.Filtro)
                                             || x.Telefone.ToLower().Contains(parametro.Filtro))
                                    .OrderBy(x => x.Nome)
                                    .AsQueryable();

            if (parametro.Pagina > 1)
                query = query.Skip(parametro.ItensPorPagina * (parametro.Pagina - 1)).AsQueryable();

            var lista = query.Take(parametro.ItensPorPagina)
                             .Select(x => new ClienteVM
                             {
                                 Id = x.Id,
                                 CriadoEm = x.CriadoEm,
                                 Nome = x.Nome,
                                 Sobrenome = x.Sobrenome,
                                 Telefone = x.Telefone,
                                 AtualizadoEm = x.AtualizadoEm
                             })
                             .ToList();

            var total = query.Count();

            return new PaginacaoRetornoVM<ClienteVM>(lista, total);
        }
    }
}