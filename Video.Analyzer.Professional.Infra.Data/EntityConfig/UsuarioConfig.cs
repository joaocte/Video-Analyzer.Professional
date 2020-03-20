using System.Data.Entity.ModelConfiguration;
using Video.Analyzer.Professional.Domain.Entities.Usuario;

namespace Video.Analyzer.Professional.Infra.Data.EntityConfig
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            HasRequired(_ => _.Perfil)
               .WithMany(_ => _.Usuarios)
               .HasForeignKey(_ => _.IdPerfil);

            HasKey(_ => _.IdUsuario);
        }
    }
}