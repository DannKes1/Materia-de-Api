namespace ApiLocadora.Models
{
    public class Genero
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
    }
}
