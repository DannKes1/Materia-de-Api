namespace ApiLocadora.DbContext
{
    using ApiLocadora.Models;
    public static class FakerBanco
    {
        public static List<Filme> Filmes = new List<Filme>();
        public static List<Genero> Generos = new List<Genero>();
        public static List<Estudio> Estudios = new List<Estudio>();
    }
}
