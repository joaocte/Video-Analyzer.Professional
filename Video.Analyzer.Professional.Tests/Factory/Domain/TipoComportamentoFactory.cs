using System;
using Video.Analyzer.Professional.Domain.Entities.Comportamento;
using Video.Analyzer.Professional.Domain.Entities.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.Domain
{
    public static class TipoComportamentoFactory
    {
        public static TipoComportamento CriarUmTipoComportamentoValido(Usuario usuario)
        {
            return new TipoComportamento
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