using System;
using Video.Analyzer.Professional.Domain.Entities.Grupo;
using Video.Analyzer.Professional.Domain.Entities.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.Domain
{
    public static class GrupoFactory
    {
        public static Grupo CriarUmGrupoValido(Usuario usuario)
        {
            return new Grupo
            {
                IdGrupo = Guid.NewGuid(),
                IdUsuario = usuario.IdUsuario,
                NomeGrupo = "nome_grupo",
                StatusGrupo = true,
                Usuario = usuario
            };
        }
    }
}