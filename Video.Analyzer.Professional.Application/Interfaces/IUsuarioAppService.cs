using System;
using System.Collections.Generic;
using UsuarioViewModel = Video.Analyzer.Professional.Application.ViewModels.Usuario.UsuarioViewModel;

namespace Video.Analyzer.Professional.Application.Interfaces
{
    public interface IUsuarioAppService : IDisposable
    {
        IEnumerable<UsuarioViewModel> GetAll();
    }
}