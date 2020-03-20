using Video.Analyzer.Professional.Domain.Entities.Animal;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Infra.Data.Interfaces;

namespace Video.Analyzer.Professional.Infra.Data.Repository
{
    public class TipoAnimalRepository : RepositoryBase<TipoAnimal>, ITipoAnimalRepository
    {
        public TipoAnimalRepository(IDbContext context) : base(context)
        {
        }
    }
}