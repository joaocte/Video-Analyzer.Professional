using System;
using System.Collections.Generic;

namespace Video.Analyzer.Professional.Domain.Interfaces.Repository.ReadyOnly
{
    public interface IAnimalRepository
    {
        IEnumerable<dynamic> GetAll(Guid IdUsuario);
    }
}