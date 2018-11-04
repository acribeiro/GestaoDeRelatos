using GestaoDeRelatosDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GestaoDeRelatosDDD.Infra.Data.EntityConfig
{
    public class RelatoConfiguration : EntityTypeConfiguration<Relato>
    {
        public RelatoConfiguration()
        {
            HasKey(r => r.RelatoId);

            Property(r => r.RelatoDescricao)
                .HasMaxLength(5000)
                .IsRequired();

            Property(r => r.Encaminhamento)
                .HasMaxLength(1000);

            Property(r => r.DataDoRelato)
                .IsRequired();

            HasRequired(e => e.Tecnico).WithMany().HasForeignKey(e => e.TecnicoId);
            HasRequired(e => e.Educador).WithMany().HasForeignKey(e => e.EducadorId);
            HasRequired(e => e.Educando).WithMany().HasForeignKey(e => e.EducandoId);
        }
    }
}
