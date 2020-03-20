using Video.Analyzer.Professional.Domain.Entities;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Infra.Data.Interfaces;

namespace Video.Analyzer.Professional.Infra.Data.Repository
{
    public class AnimalComportamentoRepository : RepositoryBase<AnimalComportamento>, IAnimalComportamentoRepository
    {
        public AnimalComportamentoRepository(IDbContext context) : base(context)
        {
        }
    }
}