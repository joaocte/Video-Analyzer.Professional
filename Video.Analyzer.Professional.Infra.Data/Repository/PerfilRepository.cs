using Video.Analyzer.Professional.Domain.Entities.Configuracao;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Infra.Data.Interfaces;

namespace Video.Analyzer.Professional.Infra.Data.Repository
{
    public class PerfilRepository : RepositoryBase<Perfil>, IPerfilRepository
    {
        public PerfilRepository(IDbContext context) : base(context)
        {
        }
    }
}