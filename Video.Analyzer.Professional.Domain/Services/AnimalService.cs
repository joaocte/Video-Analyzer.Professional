using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Domain.Entities.Animal;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Domain.Interfaces.Services;
using IAnimalRepository = Video.Analyzer.Professional.Domain.Interfaces.Repository.ReadyOnly.IAnimalRepository;

namespace Video.Analyzer.Professional.Domain.Services
{
    public class AnimalService : ServiceBase<Animal>, IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IRepositoryBase<Animal> repository, IAnimalRepository animalRepository) : base(repository)
        {
            _animalRepository = animalRepository;
        }

        public IEnumerable<dynamic> GetAll(Guid idUsuario)
        {
            return _animalRepository.GetAll(idUsuario);
        }
    }
}