namespace Domain.Entities
{
    public class Mensagem
    {
        public int Id { get; set; }
        public int ConversaId { get; set; }
        public string Conteudo { get; set; } = string.Empty;
        public bool EhUsuario { get; set; }
        public DateTime DataEnvio { get; set; } = DateTime.Now;

        public virtual Conversa Conversa { get; set; }
    }
}
