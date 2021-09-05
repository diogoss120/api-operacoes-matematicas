using Bootcamp.Repositorios;
using Bootcamp.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacaoController : ControllerBase
    {
        private readonly AutenticacaoService autenticacaoService;
        private readonly UsuarioRepositorio repositorio;

        public AutenticacaoController(AutenticacaoService autenticacaoService, UsuarioRepositorio repositorio)
        {
            this.autenticacaoService = autenticacaoService;
            this.repositorio = repositorio;
        }

        [HttpPost]
        public ActionResult<dynamic> Login(string email, string senha)
        {
            var usuario = repositorio.ObterUsuario(email, senha);

            if (usuario == null) return NotFound("Usuário não existe na base de dados, ou dados de login inválidos");

            // Gera o Token
            var token = autenticacaoService.GerarToken(usuario);

            var response = new
            {
                nome = usuario.Nome,
                email = usuario.Email,
                perfil = usuario.Perfil,
                token = token,
            };

            return Ok(response);
        }
    }
}
