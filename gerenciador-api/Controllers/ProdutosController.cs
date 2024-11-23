using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using GerenciadorApi.Models;
using GerenciadorApi.Servicos;
using GerenciadorApi.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace GerenciadorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutosController : ControllerBase
    {
        IProdutoServico _produtoServico;
        public ProdutosController(IProdutoServico produtoServico)
        {
            _produtoServico = produtoServico;
        }

        [HttpGet]
        public ActionResult<PaginacaoRetornoVM<ProdutoVM>> Get([FromQuery]PaginacaoFiltroVM parametro)
        {
            return Ok(_produtoServico.ObterLista(parametro));
        }

        [HttpGet("{id}")]
        public ActionResult<PaginacaoRetornoVM<ProdutoVM>> Get(int id)
        {
            return Ok(_produtoServico.Detalhe(id));
        }

        [HttpPost]
        public Produto Post([FromBody] Produto produto){
            if(ModelState.IsValid == false)
                return produto;
            
            _produtoServico.Salvar(produto);
            return produto;
        }

        [HttpPut("{id}")]        
        public Produto Put(int id, [FromBody] Produto produto){
            if(ModelState.IsValid == false)
                return produto;
            
            _produtoServico.Atualizar(id, produto);
            return produto;
        }
    }
}
 