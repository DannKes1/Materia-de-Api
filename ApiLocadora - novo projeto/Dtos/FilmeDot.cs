using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;

namespace ApiLocadora.Dots
{
    public class FilmeDot
    {
        [Required]
        public required string Nome { get; set; }

        [Required]
        public required string Genero { get; set; }

    }
}
