using System.Data.Entity.ModelConfiguration;
using Video.Analyzer.Professional.Domain.Entities.Animal;

namespace Video.Analyzer.Professional.Infra.Data.EntityConfig
{
    public class AnimalConfig : EntityTypeConfiguration<Animal>
    {
        public AnimalConfig()
        {
            HasKey(_ => _.IdAnimal);

            HasRequired(p => p.Usuario)
                .WithMany(p => p.Animais)
                .HasForeignKey(p => p.IdUsuario);

            HasRequired(p => p.Caixa)
               .WithMany(p => p.Animais)
               .HasForeignKey(p => p.IdCaixa);

            HasRequired(p => p.TipoAnimal)
                .WithMany(p => p.Animais)
                .HasForeignKey(p => p.IdTipoAnimal);

            HasRequired(p => p.Grupo)
                .WithMany(p => p.Animais)
                .HasForeignKey(p => p.IdGrupo);

            Ignore(c => c.ValidationResult);
        }
    }
}