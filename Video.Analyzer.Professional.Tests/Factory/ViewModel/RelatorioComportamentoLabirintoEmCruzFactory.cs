using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video.Analyzer.Professional.Application.ViewModels;

namespace Video.Analyzer.Professional.Tests.Factory.ViewModel
{
    public static class RelatorioComportamentoLabirintoEmCruzFactory
    {
        public static RelatorioComportamentoLabirintoEmCruz CriarUmRelatorioComportamentoLabirintoEmCruz()
        {
            return new RelatorioComportamentoLabirintoEmCruz
            {
                NomeAnimal = "nome_animal",
                NomeCaixa = "nome_caixa",
                NomeComportamento = "nome_comportamento",
                NomeGrupo = "nome_grupo",
                Quantidade = 10,
                Sexo = "sexo",
                Tempo = 16.3
            };
        }
    }
}