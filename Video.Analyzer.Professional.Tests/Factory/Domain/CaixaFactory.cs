using System;
using Video.Analyzer.Professional.Domain.Entities.Caixa;
using Video.Analyzer.Professional.Domain.Entities.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.Domain
{
    public static class CaixaFactory
    {
        public static Caixa CriarUmCaixaAtiva(Usuario usuario)
        {
            return new Caixa
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