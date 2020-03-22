using System;
using System.Collections.Generic;
using ComportamentoViewModel = Video.Analyzer.Professional.Application.ViewModels.Comportamento.ComportamentoViewModel;

namespace Video.Analyzer.Professional.Application.Interfaces
{
    public interface IComportamentoAppService : IDisposable
    {
        void Add(ComportamentoViewModel obj);

        IEnumerable<ComportamentoViewModel> GetAll();
    }
}