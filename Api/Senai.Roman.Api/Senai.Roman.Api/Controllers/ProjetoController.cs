using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Senai.Roman.Api.Domains;
using Senai.Roman.Api.Interfase;
using Senai.Roman.Api.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Roman.Api.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]

    public class ProjetoController : ControllerBase
    {
        private IProjetoRepository ProjetoRepository { get; set; }
        public ProjetoController ()
        {
            ProjetoRepository = new ProjetoRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {

            return Ok(ProjetoRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                Projeto projeto = ProjetoRepository.BuscarPorId(id);
                if (projeto == null)
                    return NotFound();
                return Ok(projeto);
            }
            catch (Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message });
            }
        }
        [Authorize(Roles = "Administrador")]


        [Authorize(Roles = "Administrador")]

        [HttpPost]
        public IActionResult Cadastrar(Projeto projeto)
        {
            try
            {
                ProjetoRepository.Cadastrar(projeto);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(new { mensagem = ex.Message });
            }
        }

        [Authorize(Roles = "Administrador")]

        [HttpPut]
        public IActionResult Atualizar(Projeto projeto)
        {
            Projeto ProjetoBuscado = ProjetoRepository.BuscarPorId(projeto.IdProjeto);
            if (ProjetoBuscado == null)
                return NotFound();
            ProjetoRepository.Atulizar(projeto);
            return Ok();
        }
    }
    
}
