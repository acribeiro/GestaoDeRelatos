using GestaoDeRelatosDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;


namespace GestaoDeRelatosDDD.Infra.Data.EntityConfig
{
    public class EducadorConfiguration : EntityTypeConfiguration<Educador>
    {
        public EducadorConfiguration()
        {
            HasKey(e => e.EducadorId);

            Property(e => e.Nome)
                .IsRequired();

            Property(e => e.Sobrenome)
                .IsRequired();

            Property(e => e.DataNascimento)
               .IsRequired();

            Property(e => e.Telefone)
               .IsRequired();


            HasRequired(e => e.Unidade).WithMany().HasForeignKey(e => e.UnidadeId);
            HasRequired(e => e.Oficina).WithMany().HasForeignKey(e => e.OficinaId);
        }
    }
}
