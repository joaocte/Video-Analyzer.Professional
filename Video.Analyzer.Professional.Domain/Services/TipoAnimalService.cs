using Video.Analyzer.Professional.Domain.Entities.Animal;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Domain.Interfaces.Services;

namespace Video.Analyzer.Professional.Domain.Services
{
    public class TipoAnimalService : ServiceBase<TipoAnimal>, ITipoAnimalService
    {
        public TipoAnimalService(IRepositoryBase<TipoAnimal> repository) : base(repository)
        {
        }
    }
}