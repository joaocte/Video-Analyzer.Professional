using System;
using Video.Analyzer.Professional.Application.ViewModels.Animal;
using Video.Analyzer.Professional.Application.ViewModels.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.ViewModel
{
    public static class AnimalViewModelFactory
    {
        public static AnimalViewModel CriarUmAnimal(UsuarioViewModel usuario)
        {
            var caixa = CaixaViewModelFactory.CriarUmCaixaAtiva(usuario);
            var tipoAnimal = TipoAnimalViewModelFactory.CriarUmTipoAnimalViewModelValido(usuario);
            var comportamento = ComportamentoViewModelFactory.CriarUmComportamentoViewModelValido(usuario);
            var grupo = GrupoViewModelFactory.CriarUmGrupoViewModelValido(usuario);
            return new AnimalViewModel
            {
                Caixa = caixa,
                IdCaixa = caixa.IdCaixa,
                Usuario = usuario,
                IdUsuario = usuario.IdUsuario,
                Fezes = 0,
                IdAnimal = Guid.NewGuid(),
                NomeAnimal = "nome_animal",
                Peso = "0.6",
                Sexo = "Macho",
                TipoAnimal = tipoAnimal,
                Comportamento = comportamento,
                IdComportamento = comportamento.IdComportamento,
                IdTipoAnimal = tipoAnimal.IdTipoAnimal,
                StatusAnimal = true,
                Grupo = grupo
            };
        }
    }
}