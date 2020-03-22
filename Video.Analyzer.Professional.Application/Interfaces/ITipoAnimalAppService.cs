using System;
using System.Collections.Generic;
using TipoAnimalViewModel = Video.Analyzer.Professional.Application.ViewModels.Animal.TipoAnimalViewModel;

namespace Video.Analyzer.Professional.Application.Interfaces
{
    public interface ITipoAnimalAppService : IDisposable
    {
        void Add(TipoAnimalViewModel obj);

        IEnumerable<TipoAnimalViewModel> GetAll();
    }
}