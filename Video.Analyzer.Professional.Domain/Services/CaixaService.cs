using Video.Analyzer.Professional.Domain.Entities.Caixa;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Domain.Interfaces.Services;

namespace Video.Analyzer.Professional.Domain.Services
{
    public class CaixaService : ServiceBase<Caixa>, ICaixaService
    {
        public CaixaService(IRepositoryBase<Caixa> repository) : base(repository)
        {
        }
    }
}