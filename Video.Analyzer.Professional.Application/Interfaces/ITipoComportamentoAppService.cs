using System;
using System.Collections.Generic;
using Video.Analyzer.Professional.Application.ViewModels.Comportamento;

namespace Video.Analyzer.Professional.Application.Interfaces
{
    public interface ITipoComportamentoAppService : IDisposable
    {
        void Add(TipoComportamentoViewModel obj);

        IEnumerable<TipoComportamentoViewModel> GetAll();

        TipoComportamentoViewModel GetById(Guid id);

        void Remove(TipoComportamentoViewModel obj);

        void Update(TipoComportamentoViewModel obj);
    }
}