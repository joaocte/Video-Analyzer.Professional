using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video.Analyzer.Professional.Application.ViewModels;
using Video.Analyzer.Professional.Application.ViewModels.Usuario;
using Video.Analyzer.Professional.Domain.Entities;
using Video.Analyzer.Professional.Domain.Entities.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.Domain
{
    public static class AnimalComportamentoFactory
    {
        public static AnimalComportamento CriarUmAnimalComportamento(Usuario usuario)
        {
            var comportamento = ComportamentoFactory.CriarUmComportamentoValido(usuario);
            var animal = AnimalFactory.CriarUmAnimal(usuario);
            return new AnimalComportamento
            {
                Animal = animal,
                IdAnimal = animal.IdAnimal,
                IdAnimalComportamento = Guid.NewGuid(),
                Comportamento = comportamento,
                IdComportamento = comportamento.IdComportamento,
                Tempo = 13.0,
                Quantidade = 10,
                DataAnalise = DateTime.Now,
                IdUsuario = usuario.IdUsuario,
                Usuario = usuario,
            };
        }
    }
}