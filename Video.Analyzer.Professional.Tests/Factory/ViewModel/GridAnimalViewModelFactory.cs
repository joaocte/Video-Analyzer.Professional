using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video.Analyzer.Professional.Application.ViewModels;

namespace Video.Analyzer.Professional.Tests.Factory.ViewModel
{
    public static class GridAnimalViewModelFactory
    {
        public static GridAnimalViewModel CriarUmGridAnimalViewModel()
        {
            return new GridAnimalViewModel
            {
                Fezes = 0,
                NomeAnimal = "nome_animal",
                NomeCaixa = "nome_caixa",
                NomeGrupo = "nome_grupo",
                Peso = "0.6",
                Sexo = "sexo"
            };
        }
    }
}