using Microsoft.AspNetCore.Mvc;

namespace GerenciadorApi.ViewModels
{
    public class PaginacaoFiltroVM
    {
        private string _filtro;
        private int _itensPorPagina;
        
        [FromQuery(Name = "pagina")]
        public int Pagina { get; set; }

        [FromQuery(Name = "filtro")]
        public string Filtro 
        { 
            get => string.IsNullOrEmpty(_filtro) ? string.Empty : _filtro.ToLower();  
            set => _filtro = value; 
        }

        [FromQuery(Name = "itensPorPagina")]
        public int ItensPorPagina 
        { 
            get => _itensPorPagina > 0 ? _itensPorPagina : 10; 
            set => _itensPorPagina = value;             
        }
    }
}