using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Domain.Entities;
using Video.Analyzer.Professional.Domain.Interfaces.Repository;
using Video.Analyzer.Professional.Domain.Interfaces.Services;
using IAnimalComportamentoRepository = Video.Analyzer.Professional.Domain.Interfaces.Repository.ReadyOnly.IAnimalComportamentoRepository;

namespace Video.Analyzer.Professional.Domain.Services
{
    public class AnimalComportamentoService : ServiceBase<AnimalComportamento>, IAnimalComportamentoService
    {
        private readonly IAnimalComportamentoRepository _repositoryReadyOnly;

        public AnimalComportamentoService(IRepositoryBase<AnimalComportamento> repository, IAnimalComportamentoRepository repositoryReadyOnly) : base(repository)
        {
            _repositoryReadyOnly = repositoryReadyOnly;
        }

        public void DeleteComportamentoAnimal(Guid idAnimal)
        {
            this._repositoryReadyOnly.DeleteComportamentoAnimal(idAnimal);
        }

        public IEnumerable<dynamic> GetAll(Guid IdAnimal, Guid idUsuario, DateTime? dataInicio, DateTime? dataFim, bool agrupado)
        {
            return _repositoryReadyOnly.GetAll(IdAnimal, idUsuario, dataInicio, dataFim, agrupado);
        }

        public IEnumerable<dynamic> GetAll(Guid idCaixa, Guid idUsuario, bool agrupado)
        {
            return this._repositoryReadyOnly.GetAll(idCaixa, idUsuario, agrupado);
        }
    }
}