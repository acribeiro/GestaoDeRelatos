using GestaoDeRelatosDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GestaoDeRelatosDDD.Infra.Data.EntityConfig
{
    public class TurnoConfiguration : EntityTypeConfiguration<Turno>
    {
        public TurnoConfiguration()
        {
            HasKey(t => t.TurnoId);

            Property(t => t.Nome)
                .IsRequired();
        }
    }
}
