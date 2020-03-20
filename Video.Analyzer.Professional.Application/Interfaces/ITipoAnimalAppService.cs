using System;
using System.Collections.Generic;
using TipoAnimalViewModel = Video.Analyzer.Professional.Application.ViewModels.Animal.TipoAnimalViewModel;

namespace Video.Analyzer.Professional.Application.Interfaces
{
    public interface ITipoAnimalAppService : IDisposable
    {
        void Add(TipoAnimalViewModel obj);

        IEnumerable<TipoAnimalViewModel> GetAll();

        TipoAnimalViewModel GetById(Guid id);

        void Remove(TipoAnimalViewModel obj);

        void Update(TipoAnimalViewModel obj);

        //IEnumerable<TipoAnimalViewModel> Find(Expression<Func<TipoAnimalViewModel, bool>> predicate);
    }
}