using System;
using System.Collections.Generic;

namespace Video.Analyzer.Professional.Domain.Interfaces.Repository.ReadyOnly
{
    public interface IAnimalComportamentoRepository
    {
        void DeleteComportamentoAnimal(Guid idAnimal);

        IEnumerable<dynamic> GetAll(Guid IdAnimal, Guid idUsuario, DateTime? dataInicio, DateTime? dataFim, bool agrupado);

        IEnumerable<dynamic> GetAll(Guid IdCaixa, Guid idUsuario, bool agrupado);
    }
}