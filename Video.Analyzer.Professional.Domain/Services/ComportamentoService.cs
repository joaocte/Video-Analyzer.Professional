using Video.Analyzer.Professional.Domain.Entities.Comportamento;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Domain.Interfaces.Services;

namespace Video.Analyzer.Professional.Domain.Services
{
    public class ComportamentoService : ServiceBase<Comportamento>, IComportamentoService
    {
        public ComportamentoService(IRepositoryBase<Comportamento> repository) : base(repository)
        {
        }
    }
}