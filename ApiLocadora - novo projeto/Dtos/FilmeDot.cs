using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace ApiLocadora.Dots
{
    public class FilmeDot
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string Genero { get; set; }

        [Required]
        public string Diretor { get; set; }

        [Required]
        public int AnoLancamento { get; set; }

        [Required]
        public string Estudio { get; set; } // Nome do estúdio
    }
}
