using System.Data.Entity.ModelConfiguration;
using Video.Analyzer.Professional.Domain.Entities.Animal;

namespace Video.Analyzer.Professional.Infra.Data.EntityConfig
{
    public class TipoAnimalConfig : EntityTypeConfiguration<TipoAnimal>
    {
        public TipoAnimalConfig()
        {
            HasRequired(p => p.Usuario)
                .WithMany(p => p.TiposAnimais)
                .HasForeignKey(p => p.IdUsuario);

            HasKey(_ => _.IdTipoAnimal);
        }
    }
}