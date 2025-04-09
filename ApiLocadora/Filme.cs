using Microsoft.AspNetCore.Mvc.Formatters;

namespace ApiLocadora
{
    public class Filme
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Genero { get; set; }
    }
}
