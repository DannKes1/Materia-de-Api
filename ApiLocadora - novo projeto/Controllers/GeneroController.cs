using ApiLocadora.DbContext;
using ApiLocadora.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLocadora.Controllers
{
    [Route("Genero")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        [HttpGet]
        public IActionResult Listar() => Ok(FakerBanco.Generos);

        [HttpPost]
        public IActionResult Cadastrar([FromBody] Genero genero)
        {
            FakerBanco.Generos.Add(genero);
            return Ok(genero);
        }
    }
}
