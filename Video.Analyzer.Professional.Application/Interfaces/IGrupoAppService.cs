using System;
using System.Collections.Generic;
using GrupoViewModel = Video.Analyzer.Professional.Application.ViewModels.Grupo.GrupoViewModel;

namespace Video.Analyzer.Professional.Application.Interfaces
{
    public interface IGrupoAppService : IDisposable
    {
        void Add(GrupoViewModel obj);

        IEnumerable<GrupoViewModel> GetAll();

        GrupoViewModel GetById(Guid id);

        void Remove(GrupoViewModel obj);

        void Update(GrupoViewModel obj);

        //IEnumerable<GrupoViewModel> Find(Expression<Func<Grupo, bool>> predicate);
    }
}