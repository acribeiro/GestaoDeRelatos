using GestaoDeRelatosDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeRelatosDDD.Infra.Data.EntityConfig
{
    public class EducandoConfiguration : EntityTypeConfiguration<Educando>
    {
        public EducandoConfiguration()
        {
            HasKey(e => e.EducandoId);

            Property(e => e.Nome)
                .IsRequired();

            Property(e => e.Sobrenome)
                .IsRequired();

            Property(e => e.DataNascimento)
               .IsRequired();

            Property(e => e.NomeDaMae)
               .IsRequired();

            Property(e => e.TelefoneResponsavel)
               .IsRequired();

            Property(e => e.Endereco)
               .IsRequired();

            HasRequired(e => e.Unidade).WithMany().HasForeignKey(e => e.UnidadeId);
            HasRequired(e => e.Turno).WithMany().HasForeignKey(e => e.TurnoId);

        }
    }
}
