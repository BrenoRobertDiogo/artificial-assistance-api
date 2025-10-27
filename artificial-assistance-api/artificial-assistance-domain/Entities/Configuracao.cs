namespace Domain.Entities
{
    public class Configuracao
    {
        public int Id { get; set; }
        public string Tema { get; set; } = "light"; // light ou dark
        public string ModeloIA { get; set; } = "GPT-5";
        public string Idioma { get; set; } = "pt-BR";
        public DateTime UltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
