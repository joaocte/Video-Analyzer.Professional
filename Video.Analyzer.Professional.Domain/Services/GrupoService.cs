using Video.Analyzer.Professional.Domain.Entities.Grupo;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Domain.Interfaces.Services;

namespace Video.Analyzer.Professional.Domain.Services
{
    public class GrupoService : ServiceBase<Grupo>, IGrupoService
    {
        public GrupoService(IRepositoryBase<Grupo> repository) : base(repository)
        {
        }
    }
}