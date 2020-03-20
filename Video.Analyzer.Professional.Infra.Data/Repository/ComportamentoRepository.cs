using Video.Analyzer.Professional.Domain.Entities.Comportamento;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Infra.Data.Interfaces;

namespace Video.Analyzer.Professional.Infra.Data.Repository
{
    public class ComportamentoRepository : RepositoryBase<Comportamento>, IComportamentoRepository
    {
        public ComportamentoRepository(IDbContext context) : base(context)
        {
        }
    }
}