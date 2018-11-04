using GestaoDeRelatosDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GestaoDeRelatosDDD.Infra.Data.EntityConfig
{
    public class ProfissaoConfiguration : EntityTypeConfiguration<Profissao>
    {
        public ProfissaoConfiguration()
        {
            HasKey(p => p.ProfissaoId);

            Property(o => o.Nome)
              .IsRequired();
        }
    }
}
