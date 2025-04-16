using ApiLocadora.DbContext;
using ApiLocadora.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLocadora.Controllers
{
    [Route("Estudio")]
    [ApiController]
    public class EstudioController : ControllerBase
    {
        [HttpGet]
        public IActionResult Listar() => Ok(FakerBanco.Estudios);

        [HttpPost]
        public IActionResult Cadastrar([FromBody] Estudio estudio)
        {
            FakerBanco.Estudios.Add(estudio);
            return Ok(estudio);
        }
    }
}
