using System.Data.Entity.ModelConfiguration;
using Video.Analyzer.Professional.Domain.Entities.Grupo;

namespace Video.Analyzer.Professional.Infra.Data.EntityConfig
{
    public class GrupoConfig : EntityTypeConfiguration<Grupo>
    {
        public GrupoConfig()
        {
            HasKey(_ => _.IdGrupo);
            HasRequired(p => p.Usuario)
                .WithMany(p => p.Grupos)
                .HasForeignKey(p => p.IdUsuario);
        }
    }
}