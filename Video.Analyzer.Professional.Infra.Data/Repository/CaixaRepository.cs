using Video.Analyzer.Professional.Domain.Entities.Caixa;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Infra.Data.Interfaces;

namespace Video.Analyzer.Professional.Infra.Data.Repository
{
    public class CaixaRepository : RepositoryBase<Caixa>, ICaixaRepository
    {
        public CaixaRepository(IDbContext context) : base(context)
        {
        }
    }
}