using Microsoft.AspNetCore.Mvc.Formatters;

namespace ApiLocadora.Models
{
    public class Filme
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string Diretor { get; set; }
        public string Titulo { get; set; }
        public Genero genero { get; set; }
        public Estudio estudio { get; set; }
        public int AnoLancamento { get; set; }


    }
}
