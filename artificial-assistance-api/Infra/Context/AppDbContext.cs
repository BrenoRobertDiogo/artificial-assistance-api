using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Conversa> Conversas { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }
        public DbSet<Configuracao> Configuracoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Conversa>(entity =>
            {
                entity.ToTable("Conversa");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Titulo).IsRequired().HasMaxLength(100);
                entity.Property(e => e.DataCriacao).HasColumnType("datetime");
            });

            modelBuilder.Entity<Mensagem>(entity =>
            {
                entity.ToTable("Mensagem");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Conteudo).IsRequired().HasColumnType("text");
                entity.Property(e => e.DataEnvio).HasColumnType("datetime");
                entity.HasOne(e => e.Conversa)
                      .WithMany(c => c.Mensagens)
                      .HasForeignKey(e => e.ConversaId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Configuracao>(entity =>
            {
                entity.ToTable("Configuracao");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Tema).HasMaxLength(10);
                entity.Property(e => e.ModeloIA).HasMaxLength(50);
                entity.Property(e => e.Idioma).HasMaxLength(10);
            });
        }
    }
}
