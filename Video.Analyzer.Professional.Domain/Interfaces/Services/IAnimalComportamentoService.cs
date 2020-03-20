using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Domain.Entities;

namespace Video.Analyzer.Professional.Domain.Interfaces.Services
{
    public interface IAnimalComportamentoService : IServiceBase<AnimalComportamento>
    {
        void DeleteComportamentoAnimal(Guid idAnimal);

        IEnumerable<dynamic> GetAll(Guid IdAnimal, Guid idUsuario, DateTime? dataInicio, DateTime? dataFim, bool agrupado);

        IEnumerable<dynamic> GetAll(Guid idCaixa, Guid idUsuario, bool agrupado);
    }
}