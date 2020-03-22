using System;
using Video.Analyzer.Professional.Domain.Entities.Configuracao;

namespace Video.Analyzer.Professional.Tests.Factory.Domain
{
    public static class PerfilFactory
    {
        public static Perfil CriarUmPerfilInvalido()
        {
            return new Perfil
            {
                IdPerfil = Guid.NewGuid(),
                NomePerfil = "nome_perfil",
                StatusPerfil = true
            };
        }

        public static Perfil CriarUmPerfilValido()
        {
            return new Perfil
            {
                IdPerfil = Guid.NewGuid(),
                NomePerfil = "nome_perfil_invalido",
                StatusPerfil = false
            };
        }
    }
}