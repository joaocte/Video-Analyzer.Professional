using AutoMapper;
using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Application.ViewModels;
using Video.Analyzer.Professional.Domain.Entities.Animal;
using Video.Analyzer.Professional.Domain.Interfaces.Services;
using Video.Analyzer.Professional.Infra.Data.Interfaces;
using AnimalViewModel = Video.Analyzer.Professional.Application.ViewModels.Animal.AnimalViewModel;

namespace Video.Analyzer.Professional.Application.AppServices
{
    public class AnimalAppService : AppServiceBase, IAnimalAppService
    {
        private readonly IAnimalService _animalService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public AnimalAppService(IAnimalService animalService, IUnitOfWork uow, IMapper mapper) : base(uow)
        {
            _animalService = animalService;
            _uow = uow;
            _mapper = mapper;
        }

        public void Add(AnimalViewModel obj)
        {
            _uow.BeginTransaction();
            var animal = _mapper.Map<Animal>(obj);
            _animalService.Add(animal);
            Commit();
        }

        public void Dispose()
        {
            _animalService.Dispose();
        }

        public IEnumerable<AnimalViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<AnimalViewModel>>(_animalService.GetAll());
        }

        public IEnumerable<GridAnimalViewModel> GetAll(Guid idUsuario)
        {
            return _mapper.Map<IEnumerable<GridAnimalViewModel>>(_animalService.GetAll(idUsuario));
        }

        public AnimalViewModel GetById(Guid id)
        {
            return Mapper.Map<AnimalViewModel>(_animalService.GetById(id));
        }

        public void Remove(AnimalViewModel obj)
        {
            _uow.BeginTransaction();
            var animal = _mapper.Map<Animal>(obj);
            _animalService.Remove(animal);
            Commit();
        }

        public void Update(AnimalViewModel obj)
        {
            _uow.BeginTransaction();
            var animal = _mapper.Map<Animal>(obj);
            _animalService.Update(animal);
            Commit();
        }

        //public IEnumerable<AnimalViewModel> Find(Expression<Func<AnimalViewModel, bool>> predicate)
        //{
        //    return _animalService.Find(predicate);
        //}
    }
}