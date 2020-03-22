using AutoMapper;
using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Domain.Entities.Animal;
using Video.Analyzer.Professional.Domain.Interfaces.Services;
using Video.Analyzer.Professional.Infra.Data.Interfaces;
using TipoAnimalViewModel = Video.Analyzer.Professional.Application.ViewModels.Animal.TipoAnimalViewModel;

namespace Video.Analyzer.Professional.Application.AppServices
{
    public class TipoAnimalAppService : AppServiceBase, ITipoAnimalAppService
    {
        private readonly IMapper _mapper;
        private readonly ITipoAnimalService _tipoAnimalService;
        private readonly IUnitOfWork _uow;

        public TipoAnimalAppService(ITipoAnimalService tipoAnimalService, IUnitOfWork uow, IMapper mapper) : base(uow)
        {
            _tipoAnimalService = tipoAnimalService;
            _uow = uow;
            _mapper = mapper;
        }

        public void Add(TipoAnimalViewModel obj)
        {
            _uow.BeginTransaction();
            var tipoAnimal = _mapper.Map<TipoAnimal>(obj);
            _tipoAnimalService.Add(tipoAnimal);
            Commit();
        }

        public void Dispose()
        {
            _tipoAnimalService.Dispose();
        }

        public IEnumerable<TipoAnimalViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<TipoAnimalViewModel>>(_tipoAnimalService.GetAll());
        }
    }
}