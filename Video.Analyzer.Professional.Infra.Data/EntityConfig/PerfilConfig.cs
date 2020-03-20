using System.Data.Entity.ModelConfiguration;
using Video.Analyzer.Professional.Domain.Entities.Configuracao;

namespace Video.Analyzer.Professional.Infra.Data.EntityConfig
{
    public class PerfilConfig : EntityTypeConfiguration<Perfil>
    {
        public PerfilConfig()
        {
            HasKey(_ => _.IdPerfil);
            HasMany(f => f.Menus)
               .WithMany()
               .Map(me =>
               {
                   me.MapLeftKey("PerfilId");
                   me.MapRightKey("MenuId");
                   me.ToTable("PerfilMenu");
               });
        }
    }
}