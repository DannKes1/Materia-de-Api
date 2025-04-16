
using ApiLocadora.Dots;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiLocadora.Models;
using ApiLocadora.DbContext;

namespace api_locadora.Controllers
{
    [Route("filme")]
    [ApiController]
    public class FilmeController : ControllerBase
    {

    
        [HttpGet]
        public IActionResult Buscar()
        {
            return Ok(FakerBanco.Filmes);
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] FilmeDot filme)
        {
          var genero  = FakerBanco.Generos.FirstOrDefault(g => g.Nome.ToLower() == filme.Nome.ToLower());

            if (genero == null)
            {
                genero = new Genero { Nome = filme.Genero };
                FakerBanco.Generos.Add(genero);
            }

            var filmeNovo = new Filme
            {
      
                Titulo = filme.Nome,
                genero = genero,
                Diretor = filme.Diretor,
                AnoLancamento = filme.AnoLancamento,
            };

            FakerBanco.Filmes.Add(filmeNovo);
            return Ok(filmeNovo);

        }

        [HttpPut("{id}")]

        public IActionResult Atualizar(Guid id, [FromBody] FilmeDot filme)
        {

            return Ok();

        }

        [HttpDelete("{id}")]
        public IActionResult Remover(Guid id)
        {
            var index = listafilmes.FindIndex(x => x.id == id);

            if (index == -1)
                return NotFound("Filme não encontrado.");

            listafilmes.RemoveAt(index);
            return NoContent(); // 204 - item removido com sucesso
        }

    }
}