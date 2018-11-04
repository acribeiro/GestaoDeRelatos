using GestaoDeRelatosDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GestaoDeRelatosDDD.Infra.Data.EntityConfig
{
    public class OficinaConfiguration : EntityTypeConfiguration<Oficina>
    {
        public OficinaConfiguration()
        {
            HasKey(o => o.OficinaId);

            Property(o => o.Nome)
               .IsRequired();

            Property(o => o.Descricao)
               .IsRequired();

            HasRequired(e => e.Turno).WithMany().HasForeignKey(e => e.TurnoId);

        }
    }
}
