using Video.Analyzer.Professional.Domain.Entities.Usuario;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Domain.Interfaces.Services;

namespace Video.Analyzer.Professional.Domain.Services
{
    public class UsuarioService : ServiceBase<Usuario>, IUsuarioService
    {
        public UsuarioService(IRepositoryBase<Usuario> repository) : base(repository)
        {
        }
    }
}