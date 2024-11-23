using System.Collections.Generic;
using System.Linq;
using GerenciadorApi.Models;
using GerenciadorApi.ViewModels;

namespace GerenciadorApi.Servicos
{
    public interface IDominioServico
    {
        List<NomeIdVM> ObterCategorias();
    }

    public class DominioServico : IDominioServico
    {
        private DataBaseContext _db;

        public DominioServico(DataBaseContext db)
        {
            _db = db;
        }

        public List<NomeIdVM> ObterCategorias()
        {
            var categorias = _db.Categorias.OrderBy(x => x.Nome)
                                           .Select(x => new NomeIdVM
                                                {
                                                Id = x.Id,
                                                Nome = x.Nome  
                                            })
                                            .ToList();

            return categorias;
        }
    }
}