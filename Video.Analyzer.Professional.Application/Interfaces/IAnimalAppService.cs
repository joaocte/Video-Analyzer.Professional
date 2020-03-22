using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Application.ViewModels;
using AnimalViewModel = Video.Analyzer.Professional.Application.ViewModels.Animal.AnimalViewModel;

namespace Video.Analyzer.Professional.Application.Interfaces
{
    public interface IAnimalAppService : IDisposable
    {
        void Add(AnimalViewModel obj);

        IEnumerable<AnimalViewModel> GetAll();

        IEnumerable<GridAnimalViewModel> GetAll(Guid idUsuario);
    }
}