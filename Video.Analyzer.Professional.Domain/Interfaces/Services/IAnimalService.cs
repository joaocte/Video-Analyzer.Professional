using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Domain.Entities.Animal;

namespace Video.Analyzer.Professional.Domain.Interfaces.Services
{
    public interface IAnimalService : IServiceBase<Animal>
    {
        IEnumerable<dynamic> GetAll(Guid idUsuario);
    }
}