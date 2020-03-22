using System;
using System.Collections.Generic;
using GrupoViewModel = Video.Analyzer.Professional.Application.ViewModels.Grupo.GrupoViewModel;

namespace Video.Analyzer.Professional.Application.Interfaces
{
    public interface IGrupoAppService : IDisposable
    {
        void Add(GrupoViewModel obj);

        IEnumerable<GrupoViewModel> GetAll();
    }
}