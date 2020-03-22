using System;
using Video.Analyzer.Professional.Domain.Entities.Animal;
using Video.Analyzer.Professional.Domain.Entities.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.Domain
{
    public static class AnimalFactory
    {
        public static Animal CriarUmAnimal(Usuario usuario)
        {
            var caixa = CaixaFactory.CriarUmCaixaAtiva(usuario);
            var tipoAnimal = TipoAnimalFactory.CriarUmTipoAnimalValido(usuario);
            var comportamento = ComportamentoFactory.CriarUmComportamentoValido(usuario);
            var grupo = GrupoFactory.CriarUmGrupoValido(usuario);
            return new Animal
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
                IdTipoAnimal = tipoAnimal.IdTipoAnimal,
                StatusAnimal = true,
                Grupo = grupo
            };
        }
    }
}