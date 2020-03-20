using System.Data.Entity.ModelConfiguration;
using Video.Analyzer.Professional.Domain.Entities;

namespace Video.Analyzer.Professional.Infra.Data.EntityConfig
{
    public class AnimalComportamentoConfig : EntityTypeConfiguration<AnimalComportamento>
    {
        public AnimalComportamentoConfig()
        {
            HasKey(ac => ac.IdAnimalComportamento);

            HasRequired(p => p.Usuario)
                .WithMany(p => p.AnimaisComportamento)
                .HasForeignKey(p => p.IdUsuario);

            HasRequired(p => p.Animal)
                .WithMany(p => p.AnimaisComportamentos)
                .HasForeignKey(p => p.IdAnimal);

            HasRequired(p => p.Comportamento)
                .WithMany(p => p.AnimaisComportamentos)
                .HasForeignKey(p => p.IdComportamento);
        }
    }
}