namespace ApiLocadora.Models
{
    public class Estudio
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Distribuidor { get; set; }
    }
}
