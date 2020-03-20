using Video.Analyzer.Professional.Domain.Entities.Configuracao;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Domain.Interfaces.Services;

namespace Video.Analyzer.Professional.Domain.Services
{
    public class PerfilService : ServiceBase<Perfil>, IPerfilService
    {
        public PerfilService(IRepositoryBase<Perfil> repository) : base(repository)
        {
        }
    }
}