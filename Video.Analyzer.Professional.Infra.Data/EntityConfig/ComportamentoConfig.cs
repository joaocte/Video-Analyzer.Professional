using System.Data.Entity.ModelConfiguration;
using Video.Analyzer.Professional.Domain.Entities.Comportamento;

namespace Video.Analyzer.Professional.Infra.Data.EntityConfig
{
    public class ComportamentoConfig : EntityTypeConfiguration<Comportamento>
    {
        public ComportamentoConfig()
        {
            HasKey(_ => _.IdComportamento);

            HasRequired(p => p.Usuario)
                .WithMany(p => p.Comportamentos)
                .HasForeignKey(p => p.IdUsuario);

            HasRequired(_ => _.TipoComportamento)
                .WithMany(_ => _.Comportamentos)
                .HasForeignKey(_ => _.IdTipoComportamento);

            Ignore(_ => _.Cronometro);

            Ignore(_ => _.BotaoPressionado);
        }
    }
}