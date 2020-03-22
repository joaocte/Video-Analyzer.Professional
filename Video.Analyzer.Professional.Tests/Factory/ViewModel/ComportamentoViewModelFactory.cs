using System;
using System.Diagnostics;
using Video.Analyzer.Professional.Application.ViewModels.Comportamento;
using Video.Analyzer.Professional.Application.ViewModels.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.ViewModel
{
    public static class ComportamentoViewModelFactory
    {
        public static ComportamentoViewModel CriarUmComportamentoViewModelValido(UsuarioViewModel usuario)
        {
            var tipoComportamento = TipoComportamentoViewModelFactory.CriarUmTipoComportamentoValido(usuario);
            return new ComportamentoViewModel
            {
                BotaoPressionado = true,
                Cronometro = new Stopwatch(),
                IdComportamento = Guid.NewGuid(),
                IdTipoComportamento = tipoComportamento.IdTipoComportamento,
                IdUsuario = usuario.IdUsuario,
                LetraTeclado = "K",
                NomeComportamento = "nome_comportamento",
                StatusComportamento = true,
                Usuario = usuario
            };
        }
    }
}