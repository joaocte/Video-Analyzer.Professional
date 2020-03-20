using System;
using System.Collections.Generic;
using CaixaViewModel = Video.Analyzer.Professional.Application.ViewModels.Caixa.CaixaViewModel;

namespace Video.Analyzer.Professional.Application.Interfaces
{
    public interface ICaixaAppService : IDisposable
    {
        void Add(CaixaViewModel obj);

        IEnumerable<CaixaViewModel> GetAll();

        CaixaViewModel GetById(Guid id);

        void Remove(CaixaViewModel obj);

        void Update(CaixaViewModel obj);

        //IEnumerable<CaixaViewModel> Find(Expression<Func<CaixaViewModel, bool>> predicate);
    }
}