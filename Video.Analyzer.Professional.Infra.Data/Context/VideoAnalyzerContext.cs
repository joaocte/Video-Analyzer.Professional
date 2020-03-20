using MySql.Data.Entity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Video.Analyzer.Professional.Domain.Entities;
using Video.Analyzer.Professional.Domain.Entities.Animal;
using Video.Analyzer.Professional.Domain.Entities.Caixa;
using Video.Analyzer.Professional.Domain.Entities.Comportamento;
using Video.Analyzer.Professional.Domain.Entities.Configuracao;
using Video.Analyzer.Professional.Domain.Entities.Grupo;
using Video.Analyzer.Professional.Domain.Entities.Usuario;
using Video.Analyzer.Professional.Infra.Data.EntityConfig;

namespace Video.Analyzer.Professional.Infra.Data.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class VideoAnalyzerContext : BaseDbContext
    {
        public VideoAnalyzerContext() : base("VideoAnalyzer.Local")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Animal> Animais { get; set; }
        public DbSet<AnimalComportamento> AnimaisComportamentos { get; set; }
        public DbSet<Caixa> Caixas { get; set; }
        public DbSet<Comportamento> Comportamentos { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Perfil> Perfis { get; set; }
        public DbSet<TipoComportamento> TipoComportamentos { get; set; }
        public DbSet<TipoAnimal> TiposAnimais { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new AnimalConfig());
            modelBuilder.Configurations.Add(new CaixaConfig());
            modelBuilder.Configurations.Add(new ComportamentoConfig());
            modelBuilder.Configurations.Add(new GrupoConfig());
            modelBuilder.Configurations.Add(new MenuConfig());
            modelBuilder.Configurations.Add(new PerfilConfig());
            modelBuilder.Configurations.Add(new TipoAnimalConfig());
            modelBuilder.Configurations.Add(new UsuarioConfig());
            modelBuilder.Configurations.Add(new AnimalComportamentoConfig());
            modelBuilder.Configurations.Add(new TipoComportamentoConfig());
            //modelBuilder.Configurations.Add(new MysqlContextConfiguration());

            //modelBuilder.Properties()
            //    .Where(p => p.Name == p.ReflectedType.Name + "Id")
            //    .Configure(p => p.IsKey());
        }
    }
}