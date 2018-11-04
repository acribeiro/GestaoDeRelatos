using GestaoDeRelatosDDD.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace GestaoDeRelatosDDD.Infra.Data.EntityConfig
{
    public class UnidadeConfiguration : EntityTypeConfiguration<Unidade>
    {
        public UnidadeConfiguration()
        {
            HasKey(u => u.UnidadeId);

            Property(u => u.Nome)
                .IsRequired();

            Property(u => u.Endereco)
               .IsRequired();
        }
    }
}
