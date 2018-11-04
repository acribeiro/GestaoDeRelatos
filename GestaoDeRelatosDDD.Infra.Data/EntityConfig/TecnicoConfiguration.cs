using GestaoDeRelatosDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GestaoDeRelatosDDD.Infra.Data.EntityConfig
{
    public class TecnicoConfiguration : EntityTypeConfiguration<Tecnico>
    {
        public TecnicoConfiguration()
        {
            HasKey(t => t.TecnicaId);

            Property(t => t.Nome)
               .IsRequired();

            Property(t => t.Sobrenome)
               .IsRequired();

            Property(t => t.Nome)
               .IsRequired();

            Property(t => t.DataNascimento)
               .IsRequired();

            Property(t => t.Telefone)
               .IsRequired();

            Property(t => t.RegistroProfissinal)
              .IsRequired();

            HasRequired(e => e.Unidade).WithMany().HasForeignKey(e => e.UnidadeId);
            HasRequired(e => e.Profissao).WithMany().HasForeignKey(e => e.ProfissaoId);
        }
    }
}
