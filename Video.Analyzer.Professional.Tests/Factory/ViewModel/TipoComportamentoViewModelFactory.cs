using System;
using Video.Analyzer.Professional.Application.ViewModels.Comportamento;
using Video.Analyzer.Professional.Application.ViewModels.Usuario;
using Video.Analyzer.Professional.Domain.Entities.Comportamento;
using Video.Analyzer.Professional.Domain.Entities.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.ViewModel
{
    public static class TipoComportamentoViewModelFactory
    {
        public static TipoComportamentoViewModel CriarUmTipoComportamentoValido(UsuarioViewModel usuario)
        {
            return new TipoComportamentoViewModel
            {
                IdTipoComportamento = Guid.NewGuid(),
                IdUsuario = usuario.IdUsuario,
                NomeTipoComportamento = "nome_tipo_comportamento",
                StatusTipoComportamento = true,
                Usuario = usuario
            };
        }
    }
}