using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video.Analyzer.Professional.Application.ViewModels;
using Video.Analyzer.Professional.Application.ViewModels.Usuario;

namespace Video.Analyzer.Professional.Tests.Factory.ViewModel
{
    public static class AnimalComportamentoViewModelFactory
    {
        public static AnimalComportamentoViewModel CriarUmAnimalComportamentoViewModel(UsuarioViewModel usuario)
        {
            var comportamento = ComportamentoViewModelFactory.CriarUmComportamentoViewModelValido(usuario);
            var animal = AnimalViewModelFactory.CriarUmAnimal(usuario);
            return new AnimalComportamentoViewModel
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