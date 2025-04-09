
using ApiLocadora.Dots;
using ApiLocadora;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_locadora.Controllers
{
    [Route("filme")]
    [ApiController]
    public class FilmeController : ControllerBase
    {
        private static List<Filme> listafilmes = [
            new Filme() {
                Nome = "1984",
                Genero = "Vitao"
            },
        new Filme(){
                Nome = "1985",
                Genero = "Daniel"
            },
        new Filme() {
         Nome = "1986",
        Genero = "Gabriel"}];


        [HttpGet]
        public IActionResult Buscar()
        {
            
            return Ok(listafilmes);
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] FilmeDot filme)
        {
            var filmeNovo = new Filme();
            filmeNovo.Nome = filme.Nome;
            filmeNovo.Genero = filme.Genero;
         

            listafilmes.Add(filmeNovo);
            return Ok(listafilmes);


        }

        [HttpPut("{id}")]

        public IActionResult Atualizar(Guid id, [FromBody] FilmeDot filme)
        {

            return Ok();

        }

        [HttpDelete("{id}")]

        public IActionResult Remover (Guid id)
        {
            var index = listafilmes.FindIndex(x => x.id == id);

            return Ok();
        }

    }
}