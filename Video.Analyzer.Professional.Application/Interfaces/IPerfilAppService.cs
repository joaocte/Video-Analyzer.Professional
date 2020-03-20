using System;
using System.Collections.Generic;
using PerfilViewModel = Video.Analyzer.Professional.Application.ViewModels.Configuracao.PerfilViewModel;

namespace Video.Analyzer.Professional.Application.Interfaces
{
    public interface IPerfilAppService : IDisposable
    {
        void Add(PerfilViewModel obj);

        IEnumerable<PerfilViewModel> GetAll();

        PerfilViewModel GetById(Guid id);

        void Remove(PerfilViewModel obj);

        void Update(PerfilViewModel obj);

        //IEnumerable<PerfilViewModel> Find(Expression<Func<PerfilViewModel, bool>> predicate);
    }
}