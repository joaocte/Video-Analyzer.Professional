using AutoMapper;
using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Application.Interfaces;
using Video.Analyzer.Professional.Application.ViewModels;
using Video.Analyzer.Professional.Domain.Entities;
using Video.Analyzer.Professional.Domain.Interfaces.Services;
using Video.Analyzer.Professional.Infra.Data.Interfaces;

namespace Video.Analyzer.Professional.Application.AppServices
{
    public class AnimalComportamentoAppService : AppServiceBase, IAnimalComportamentoAppService
    {
        private readonly IAnimalComportamentoService _animalComportamentoService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public AnimalComportamentoAppService(IUnitOfWork uow, IMapper mapper, IAnimalComportamentoService animalComportamentoService) : base(uow)
        {
            _uow = uow;
            _mapper = mapper;
            _animalComportamentoService = animalComportamentoService;
        }

        public void Add(AnimalComportamentoViewModel obj)
        {
            _uow.BeginTransaction();
            var caixa = _mapper.Map<AnimalComportamento>(obj);
            _animalComportamentoService.Add(caixa);
            Commit();
        }

        public void DeleteComportamentoAnimal(Guid idAnimal)
        {
            this._uow.BeginTransaction();
            this._animalComportamentoService.DeleteComportamentoAnimal(idAnimal);
            this.Commit();
        }

        public void Dispose()
        {
            _animalComportamentoService.Dispose();
        }

        public IEnumerable<AnimalComportamentoViewModel> GetAll()
        {
            return _mapper.Map<IEnumerable<AnimalComportamentoViewModel>>(_animalComportamentoService.GetAll());
        }

        public IEnumerable<RelatorioComportamentoLabirintoEmCruz> GetAll(Guid idCaixa, Guid idUsuario, bool agrupado)
        {
            return _mapper.Map<IEnumerable<RelatorioComportamentoLabirintoEmCruz>>(_animalComportamentoService.GetAll(idCaixa, idUsuario, agrupado));
        }
    }
}