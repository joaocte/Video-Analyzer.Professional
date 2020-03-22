using System;
using Video.Analyzer.Professional.Application.ViewModels.Animal;
using Video.Analyzer.Professional.Application.ViewModels.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.ViewModel
{
    public static class TipoAnimalViewModelFactory
    {
        public static TipoAnimalViewModel CriarUmTipoAnimalViewModelInvalido(UsuarioViewModel usuario)
        {
            return new TipoAnimalViewModel
            {
                IdTipoAnimal = Guid.NewGuid(),
                IdUsuario = usuario.IdUsuario,
                NomeTipoAnimal = "nome_tipo_animal",
                StatusTipoAnimal = true,
                Usuario = usuario
            };
        }

        public static TipoAnimalViewModel CriarUmTipoAnimalViewModelValido(UsuarioViewModel usuario)
        {
            return new TipoAnimalViewModel
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