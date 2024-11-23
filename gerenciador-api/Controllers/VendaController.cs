using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GerenciadorApi.Servicos;
using GerenciadorApi.ViewModels;

namespace GerenciadorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VendaController : ControllerBase
    {
        IVendaServico _vendaServico;
        public VendaController(IVendaServico vendaServico)
        {
            _vendaServico = vendaServico;
        }

        [HttpPost]
        public async Task<ActionResult<VendaVM>> Post([FromBody] VendaVM venda){
            
            try
            {
                if(ModelState.IsValid == false)
                return venda;
            
                await _vendaServico.Salvar(venda);
                return venda;
            }
            catch (ArgumentException e)
            {
                return BadRequest(e.Message);
            }            
        }
    }
}
 