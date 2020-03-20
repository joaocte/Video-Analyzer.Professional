using DomainValidation.Interfaces.Specification;
using System;
using Video.Analyzer.Professional.Domain.Entities.Animal;

namespace Video.Analyzer.Professional.Domain.Specification
{
    internal class ValidaAnimalSpecification : ISpecification<Animal>
    {
        public bool IsSatisfiedBy(Animal entity)
        {
            return entity.IdTipoAnimal != Guid.Empty && entity.IdGrupo != Guid.Empty && entity.IdUsuario != Guid.Empty
                && entity.IdAnimal != Guid.Empty;
        }
    }
}