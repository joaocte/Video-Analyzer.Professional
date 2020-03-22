using System;
using Video.Analyzer.Professional.Application.ViewModels.Configuracao;

namespace Video.Analyzer.Professional.Tests.Factory.ViewModel
{
    public static class PerfilViewModelFactory
    {
        public static PerfilViewModel CriarUmPerfilInvalido()
        {
            return new PerfilViewModel
            {
                IdPerfil = Guid.NewGuid(),
                NomePerfil = "nome_perfil",
                StatusPerfil = true
            };
        }

        public static PerfilViewModel CriarUmPerfilValido()
        {
            return new PerfilViewModel
            {
                IdPerfil = Guid.NewGuid(),
                NomePerfil = "nome_perfil_invalido",
                StatusPerfil = false
            };
        }
    }
}