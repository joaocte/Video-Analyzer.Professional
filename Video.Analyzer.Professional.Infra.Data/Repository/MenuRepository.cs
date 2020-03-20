using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Infra.Data.Interfaces;
using Menu = Video.Analyzer.Professional.Domain.Entities.Configuracao.Menu;

namespace Video.Analyzer.Professional.Infra.Data.Repository
{
    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbContext context) : base(context)
        {
        }
    }
}