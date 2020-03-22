using System;
using Video.Analyzer.Professional.Application.ViewModels.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.ViewModel
{
    public static class UsuarioViewModelFactory
    {
        public static UsuarioViewModel CriarUmUsuarioInvalido()
        {
            var perfil = PerfilViewModelFactory.CriarUmPerfilValido();
            return new UsuarioViewModel
            {
                Email = "teste@teste.com.br",
                IdPerfil = perfil.IdPerfil,
                IdUsuario = Guid.NewGuid(),
                NomeUsuario = "nome_usuario",
                Perfil = perfil,
                Salt = "salt",
                Senha = "senha",
                StatusUsuario = true
            };
        }

        public static UsuarioViewModel CriarUmUsuarioValido()
        {
            var perfil = PerfilViewModelFactory.CriarUmPerfilValido();
            return new UsuarioViewModel
            {
                Email = "teste@teste.com.br",
                IdPerfil = perfil.IdPerfil,
                IdUsuario = Guid.NewGuid(),
                NomeUsuario = "nome_usuario",
                Perfil = perfil,
                Salt = "salt",
                Senha = "senha",
                StatusUsuario = true
            };
        }
    }
}