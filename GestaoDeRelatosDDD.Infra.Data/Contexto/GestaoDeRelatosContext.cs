using GestaoDeRelatosDDD.Domain.Entities;
using GestaoDeRelatosDDD.Infra.Data.EntityConfig;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace GestaoDeRelatosDDD.Infra.Data.Contexto
{
    public class GestaoDeRelatosContext : DbContext
    {
        public GestaoDeRelatosContext()
            : base("GestaoDeRelatosDDD")
        {

        }

        public DbSet<Educando> Educando { get; set; }
        public DbSet<Tecnico> Tecnico { get; set; }
        public DbSet<Educador> Educador { get; set; }
        public DbSet<Oficina> Oficina { get; set; }
        public DbSet<Relato> Relato { get; set; }
        public DbSet<Unidade> Unidade { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<Profissao> Profissao { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(150));

            modelBuilder.Configurations.Add(new EducadorConfiguration());
            modelBuilder.Configurations.Add(new EducandoConfiguration());
            modelBuilder.Configurations.Add(new OficinaConfiguration());
            modelBuilder.Configurations.Add(new ProfissaoConfiguration());
            modelBuilder.Configurations.Add(new TecnicoConfiguration());
            modelBuilder.Configurations.Add(new TurnoConfiguration());
            modelBuilder.Configurations.Add(new UnidadeConfiguration());
            modelBuilder.Configurations.Add(new RelatoConfiguration());

        }
    }
}
