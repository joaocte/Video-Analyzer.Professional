using System.Data.Entity.ModelConfiguration;
using Video.Analyzer.Professional.Domain.Entities.Comportamento;

namespace Video.Analyzer.Professional.Infra.Data.EntityConfig
{
    public class TipoComportamentoConfig : EntityTypeConfiguration<TipoComportamento>
    {
        public TipoComportamentoConfig()
        {
            HasKey(t => t.IdTipoComportamento);
        }
    }
}