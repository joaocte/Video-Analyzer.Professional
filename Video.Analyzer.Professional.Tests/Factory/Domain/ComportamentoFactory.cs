using System;
using System.Diagnostics;
using Video.Analyzer.Professional.Domain.Entities.Comportamento;
using Video.Analyzer.Professional.Domain.Entities.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.Domain
{
    public static class ComportamentoFactory
    {
        public static Comportamento CriarUmComportamentoValido(Usuario usuario)
        {
            var tipoComportamento = TipoComportamentoFactory.CriarUmTipoComportamentoValido(usuario);
            return new Comportamento
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