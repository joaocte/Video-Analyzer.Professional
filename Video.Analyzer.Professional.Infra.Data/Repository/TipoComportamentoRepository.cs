using Video.Analyzer.Professional.Domain.Entities.Comportamento;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Infra.Data.Interfaces;

namespace Video.Analyzer.Professional.Infra.Data.Repository
{
    public class TipoComportamentoRepository : RepositoryBase<TipoComportamento>, ITipoComportamentoRepository
    {
        public TipoComportamentoRepository(IDbContext context) : base(context)
        {
        }
    }
}