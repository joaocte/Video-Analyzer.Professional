using System;
using Video.Analyzer.Professional.Domain.Entities.Animal;
using Video.Analyzer.Professional.Domain.Entities.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.Domain
{
    public static class TipoAnimalFactory
    {
        public static TipoAnimal CriarUmTipoAnimalInvalido(Usuario usuario)
        {
            return new TipoAnimal
            {
                IdTipoAnimal = Guid.NewGuid(),
                IdUsuario = usuario.IdUsuario,
                NomeTipoAnimal = "nome_tipo_animal",
                StatusTipoAnimal = true,
                Usuario = usuario
            };
        }

        public static TipoAnimal CriarUmTipoAnimalValido(Usuario usuario)
        {
            return new TipoAnimal
            {
                IdTipoAnimal = Guid.NewGuid(),
                IdUsuario = usuario.IdUsuario,
                NomeTipoAnimal = "nome_tipo_animal",
                StatusTipoAnimal = false,
                Usuario = usuario
            };
        }
    }
}