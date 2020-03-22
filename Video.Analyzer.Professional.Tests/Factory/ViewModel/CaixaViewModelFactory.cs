using System;
using Video.Analyzer.Professional.Application.ViewModels.Caixa;
using Video.Analyzer.Professional.Application.ViewModels.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.ViewModel
{
    public static class CaixaViewModelFactory
    {
        public static CaixaViewModel CriarUmCaixaAtiva(UsuarioViewModel usuario)
        {
            return new CaixaViewModel
            {
                IdCaixa = Guid.NewGuid(),
                IdUsuario = usuario.IdUsuario,
                NomeCaixa = "nome_caixa",
                StatusCaixa = true,
                Usuario = usuario
            };
        }
    }
}