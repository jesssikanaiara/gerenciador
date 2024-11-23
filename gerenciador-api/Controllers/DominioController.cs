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
    public class DominioController : ControllerBase
    {
        IDominioServico _dominioService;

        public DominioController(IDominioServico dominioServico)
        {
            _dominioService = dominioServico;
        }

        [HttpGet]
        [Route("categorias")]
        public ActionResult<List<NomeIdVM>> Get()
        {
            return Ok(_dominioService.ObterCategorias());
        }    
    }
}
 