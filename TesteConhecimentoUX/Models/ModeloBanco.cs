using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TesteConhecimentoUX.Models
{
    public partial class ModeloBanco : DbContext
    {
        public ModeloBanco()
            : base("name=ModeloBanco")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<Atividade> Atividade { get; set; }
        public virtual DbSet<Pacote> Pacote { get; set; }
        public virtual DbSet<Participante> Participante { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Atividade>()
                .Property(e => e.DescAtv)
                .IsUnicode(false);

            modelBuilder.Entity<Atividade>()
                .Property(e => e.Preco)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Pacote>()
                .Property(e => e.Preco)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Pacote>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Participante>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Participante>()
                .Property(e => e.Telefone)
                .IsUnicode(false);
        }
    }
}
