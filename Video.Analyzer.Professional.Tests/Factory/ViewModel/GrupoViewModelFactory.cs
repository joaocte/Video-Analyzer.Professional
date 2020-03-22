using System;
using Video.Analyzer.Professional.Application.ViewModels.Grupo;
using Video.Analyzer.Professional.Application.ViewModels.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.ViewModel
{
    public static class GrupoViewModelFactory
    {
        public static GrupoViewModel CriarUmGrupoViewModelValido(UsuarioViewModel usuario)
        {
            return new GrupoViewModel
            {
                IdGrupo = Guid.NewGuid(),
                IdUsuario = usuario.IdUsuario,
                NomeGrupo = "nome_grupo",
                StatusGrupo = true,
                Usuario = usuario
            };
        }
    }
}