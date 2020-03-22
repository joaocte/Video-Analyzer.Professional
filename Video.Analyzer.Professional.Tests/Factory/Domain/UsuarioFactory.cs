using System;
using Video.Analyzer.Professional.Domain.Entities.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.Domain
{
    public static class UsuarioFactory
    {
        public static Usuario CriarUmUsuarioInvalido(Guid idUsuario)
        {
            var perfil = PerfilFactory.CriarUmPerfilValido();
            return new Usuario
            {
                Email = "teste@teste.com.br",
                IdPerfil = perfil.IdPerfil,
                IdUsuario = idUsuario,
                NomeUsuario = "nome_usuario",
                Perfil = perfil,
                Salt = "salt",
                Senha = "senha",
                StatusUsuario = true
            };
        }

        public static Usuario CriarUmUsuarioValido(Guid idUsuario)
        {
            var perfil = PerfilFactory.CriarUmPerfilValido();
            return new Usuario
            {
                Email = "teste@teste.com.br",
                IdPerfil = perfil.IdPerfil,
                IdUsuario = idUsuario,
                NomeUsuario = "nome_usuario",
                Perfil = perfil,
                Salt = "salt",
                Senha = "senha",
                StatusUsuario = true
            };
        }
    }
}