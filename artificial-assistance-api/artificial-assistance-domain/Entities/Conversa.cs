namespace Domain.Entities
{
    public class Conversa
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public DateTime DataCriacao { get; set; } = DateTime.Now;

        public virtual ICollection<Mensagem> Mensagens { get; set; } = new List<Mensagem>();
    }
}
