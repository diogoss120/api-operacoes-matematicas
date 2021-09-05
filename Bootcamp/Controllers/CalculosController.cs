using Bootcamp.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Bootcamp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculosController : ControllerBase
    {
        [HttpPost]
        [Route("SomaDoisNumeros")]
        public IActionResult SomaDoisNumeros([FromBody] Calculos numeros)
        {
            return Ok(numeros.Soma());
        }

        [Authorize]
        [HttpPost]
        [Route("MultiplicaDoisNumeros")]
        public IActionResult MultiplicaDoisNumeros([FromBody] Calculos numeros)
        {
            return Ok(numeros.Multiplicacao());
        }

        [Authorize(Roles = "Matematico")]
        [HttpPost]
        [Route("DivisaoDeDoisNumeros")]
        public IActionResult DivisaoDeDoisNumeros([FromBody] Calculos numeros)
        {
            try
            {
                return Ok(numeros.Divisao());
            }
            catch(ArgumentException e)
            {
                return BadRequest(e.Message);
            }
            
        }
    }
}
