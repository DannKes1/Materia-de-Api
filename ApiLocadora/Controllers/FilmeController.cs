using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiLocadora.Controllers
{
    [Route("filmes")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        [HttpGet]

        public IActionResult BuscaFilmes()
        {
            List<Filme> filmes = new List<Filme>();

            filmes.Add(new Filme
            {

                Nome = "Fast and Furios",
                Genero = "Action"
            });

            filmes.Add(new Filme
            {

                Nome = "Fast and Furios II",
                Genero = "Action"
            });


            return Ok(filmes);
            
        }

    }
}
