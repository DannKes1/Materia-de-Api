using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLocadora.Controllers
{
    [Route("Sobre")]
    [ApiController]
    public class SobreController : ControllerBase
    {
        [HttpGet]

        public IActionResult Sobre()
        {
            
            return Ok("Descrição, Autor");

        }

        // Sub-rota Sobre Autor
        [HttpGet("Equipe")]
        public IActionResult Equipe()
        {
            return Ok("Nome, email, descrição");
        }

    }
}
