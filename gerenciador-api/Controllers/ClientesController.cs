using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GerenciadorApi.Models;
using GerenciadorApi.Servicos;
using GerenciadorApi.ViewModels;

namespace GerenciadorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        IClienteServico _clienteServico;
        public ClientesController(IClienteServico clienteServico)
        {
            _clienteServico = clienteServico;
        }

        [HttpGet]
        public ActionResult<PaginacaoRetornoVM<ClienteVM>> Get([FromQuery]PaginacaoFiltroVM parametro)
        {
            return Ok(_clienteServico.ObterLista(parametro));
        }

        [HttpPost]
        public Cliente Post([FromBody] Cliente cliente){
            if(ModelState.IsValid == false)
                return cliente;
            
            _clienteServico.Salvar(cliente);
            return cliente;
        }
    }
}
 