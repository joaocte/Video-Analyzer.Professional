using Video.Analyzer.Professional.Domain.Entities.Configuracao;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Domain.Interfaces.Services;

namespace Video.Analyzer.Professional.Domain.Services
{
    public class MenuService : ServiceBase<Menu>, IMenuService
    {
        public MenuService(IRepositoryBase<Menu> repository) : base(repository)
        {
        }
    }
}