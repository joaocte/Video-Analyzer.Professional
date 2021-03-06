﻿using System;
using Video.Analyzer.Professional.Application.ViewModels.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.ViewModel
{
    public static class UsuarioViewModelFactory
    {
        public static UsuarioViewModel CriarUmUsuarioInvalido(Guid idUsuario)
        {
            var perfil = PerfilViewModelFactory.CriarUmPerfilValido();
            return new UsuarioViewModel
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

        public static UsuarioViewModel CriarUmUsuarioValido(Guid idUsuario)
        {
            var perfil = PerfilViewModelFactory.CriarUmPerfilValido();
            return new UsuarioViewModel
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