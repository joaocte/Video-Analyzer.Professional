using System;
using System.Collections.Generic;
using UsuarioViewModel = Video.Analyzer.Professional.Application.ViewModels.Usuario.UsuarioViewModel;

namespace Video.Analyzer.Professional.Application.Interfaces
{
    public interface IUsuarioAppService : IDisposable
    {
        void Add(UsuarioViewModel obj);

        IEnumerable<UsuarioViewModel> GetAll();

        UsuarioViewModel GetById(Guid id);

        void Remove(UsuarioViewModel obj);

        void Update(UsuarioViewModel obj);

        //IEnumerable<UsuarioViewModel> Find(Expression<Func<UsuarioViewModel, bool>> predicate);
    }
}