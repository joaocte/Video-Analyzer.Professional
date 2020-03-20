using Video.Analyzer.Professional.Domain.Entities.Comportamento;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Domain.Interfaces.Services;

namespace Video.Analyzer.Professional.Domain.Services
{
    public class TipoComportamentoService : ServiceBase<TipoComportamento>, ITipoComportamentoService
    {
        public TipoComportamentoService(IRepositoryBase<TipoComportamento> repository) : base(repository)
        {
        }
    }
}