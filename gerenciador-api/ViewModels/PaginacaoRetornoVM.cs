using System.Collections.Generic;

namespace GerenciadorApi.ViewModels
{
    public class PaginacaoRetornoVM<T>
    {
        public PaginacaoRetornoVM(List<T> lista, int totalItens)
        {
            Lista = lista;
            TotalItens = totalItens;
        }

        public List<T> Lista { get; set; }
        public int TotalItens { get; set; }
    }
}