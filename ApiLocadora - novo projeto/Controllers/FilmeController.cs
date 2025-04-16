
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
        public IActionResult Cadastrar([FromBody] FilmeDot filmeDto)
        {
            var genero = FakerBanco.Generos.FirstOrDefault(g => g.Nome.ToLower() == filmeDto.Genero.ToLower());
            if (genero == null)
            {
                genero = new Genero { Nome = filmeDto.Genero };
                FakerBanco.Generos.Add(genero);
            }

            var estudio = FakerBanco.Estudios.FirstOrDefault(e => e.Nome.ToLower() == filmeDto.Estudio.ToLower());
            if (estudio == null)
            {
                estudio = new Estudio { Nome = filmeDto.Estudio, Distribuidor = "Desconhecido" };
                FakerBanco.Estudios.Add(estudio);
            }

            var novoFilme = new Filme
            {
                Titulo = filmeDto.Nome,
                Diretor = filmeDto.Diretor,
                AnoLancamento = filmeDto.AnoLancamento,
                genero = genero,
                estudio = estudio
            };

            FakerBanco.Filmes.Add(novoFilme);

            return Ok(novoFilme);

        }

        [HttpPut("{id}")]

        public IActionResult Atualizar(Guid id, [FromBody] FilmeDot filmeDto)
        {
            var filme = FakerBanco.Filmes.FirstOrDefault(f => f.id == id);
            if (filme == null)
                return NotFound("Filme não encontrado.");

            filme.Titulo = filmeDto.Nome;
            filme.Diretor = filmeDto.Diretor;
            filme.AnoLancamento = filmeDto.AnoLancamento;

            var genero = FakerBanco.Generos.FirstOrDefault(g => g.Nome.ToLower() == filmeDto.Genero.ToLower())
                         ?? new Genero { Nome = filmeDto.Genero };
            filme.genero = genero;

            var estudio = FakerBanco.Estudios.FirstOrDefault(e => e.Nome.ToLower() == filmeDto.Estudio.ToLower())
                          ?? new Estudio { Nome = filmeDto.Estudio, Distribuidor = "Desconhecido" };
            filme.estudio = estudio;

            return Ok(filme);
        }

        [HttpDelete("{id}")]
        public IActionResult Remover(Guid id)
        {
            var index = FakerBanco.Filmes.FindIndex(f => f.id == id);
            if (index == -1)
                return NotFound("Filme não encontrado.");

            FakerBanco.Filmes.RemoveAt(index);
            return NoContent();
        }


    }
}